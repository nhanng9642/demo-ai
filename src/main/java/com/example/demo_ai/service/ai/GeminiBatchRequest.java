package com.example.demo_ai.service.ai;


import com.example.demo_ai.domain.Chunk;
import lombok.Getter;
import lombok.Setter;

import java.util.ArrayList;
import java.util.List;

@Getter
@Setter
public class GeminiBatchRequest {
    List<GeminiEmbeddingRequest> requests;

    public static GeminiBatchRequest of(String model, List<Chunk> chunks) {
        GeminiBatchRequest batchRequest = new GeminiBatchRequest();
        var requests = chunks.stream()
                .map(chunk -> {
                    GeminiEmbeddingRequest request = new GeminiEmbeddingRequest();
                    request.setModel(model);
                    GeminiEmbeddingRequest.Content content = new GeminiEmbeddingRequest.Content();
                    GeminiEmbeddingRequest.Part part = new GeminiEmbeddingRequest.Part();
                    part.setText(chunk.getContent());
                    content.setParts(new ArrayList<>(List.of(part)));
                    request.setContent(content);
                    return request;
                })
                .toList();
        batchRequest.setRequests(requests);
        return batchRequest;
    }

    @Getter
    @Setter
    private static class GeminiEmbeddingRequest {
        private String model;
        private Content content;

        public GeminiEmbeddingRequest() {

        }
        @Getter
        @Setter
        private static class Content {
            private List<Part> parts;
        }

        @Getter
        @Setter
        private static class Part {
            private String text;
        }
    }
}


