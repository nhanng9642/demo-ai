package com.example.demo_ai.service;

import com.example.demo_ai.domain.Chunk;
import com.example.demo_ai.repository.ChunkRepository;
import com.example.demo_ai.Submission;
import com.example.demo_ai.SubmissionRepository;
import com.example.demo_ai.service.ai.AIService;
import com.example.demo_ai.service.split.FileService;
import jakarta.transaction.Transactional;
import lombok.RequiredArgsConstructor;
import org.springframework.stereotype.Service;

import java.io.File;
import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Path;
import java.util.Date;
import java.util.List;
import java.util.stream.Stream;

@Service
@RequiredArgsConstructor
public class EmbeddingService {
    private final ChunkRepository chunkRepository;
    private final SubmissionRepository submissionRepository;
    private final FileService fileService;
    private final AIService aiService;

    @Transactional
    public Long saveSubmission(File project) throws IOException {
        Path unzipPath = fileService.unzipFile(project);
//        System.out.println(unzipPath);

        Submission sb = new Submission();
        sb.setPath(unzipPath.toString());
        sb.setDate(new Date());
        var submission = submissionRepository.save(sb);
        Long id = submission.getId();

        try (Stream<Path> paths = Files.walk(unzipPath)) {
            paths.filter(FileService::isCodeFile)
                    .forEach(file -> {
                        List<Chunk> chunks = fileService.split(file.toFile(), id);
                        aiService.getEmbeddingVector(chunks);
                        chunkRepository.saveAll(chunks);
                    });
        } catch (IOException e) {
            e.printStackTrace();
        }
        return id;
    }
}
