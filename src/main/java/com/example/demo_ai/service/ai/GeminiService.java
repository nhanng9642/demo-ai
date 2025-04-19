package com.example.demo_ai.service.ai;

import com.example.demo_ai.domain.Chunk;
import lombok.RequiredArgsConstructor;
import org.springframework.beans.factory.annotation.Value;
import org.springframework.http.*;
import org.springframework.stereotype.Service;
import org.springframework.web.client.RestTemplate;

import java.util.List;

@Service
@RequiredArgsConstructor
public class GeminiService implements AIService{
    private final String MODEL = "models/text-embedding-004";
    private final RestTemplate restTemplate = new RestTemplate();

    @Value("${spring.application.gemini.api-key}")
    private static String GEMINI_API_KEY;

    private static final String GEMINI_API_URL =
            "https://generativelanguage.googleapis.com/v1beta/models/text-embedding-004:batchEmbedContents?key=" + GEMINI_API_KEY;

    @Override
    public void getEmbeddingVector(List<Chunk> chunks) {
        if (chunks.isEmpty())
            return;
        var request = GeminiBatchRequest.of(MODEL, chunks);
        HttpHeaders headers = new HttpHeaders();
        headers.setContentType(MediaType.APPLICATION_JSON);
        var httpEntity = new HttpEntity<>(request, headers);

        ResponseEntity<GeminiEmbeddingResponse> response = restTemplate.exchange
                (GEMINI_API_URL, HttpMethod.POST, httpEntity, GeminiEmbeddingResponse.class);

        if (response.getStatusCode() == HttpStatus.OK) {
            GeminiEmbeddingResponse embeddingResponse = response.getBody();
            if (embeddingResponse != null && embeddingResponse.getEmbeddings() != null) {
                for (int i = 0; i < chunks.size(); i++) {
                    var chunk = chunks.get(i);
                    var embeddingVector = embeddingResponse.getEmbeddingVector(i);
                    chunk.setEmbedding(embeddingVector);
                }
            }
        } else {
            System.out.println("Error: " + response.getStatusCode());
        }
    }
}
