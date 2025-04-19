package com.example.demo_ai.service;

import com.example.demo_ai.domain.PlagiarismInfo;
import com.example.demo_ai.domain.PlagiarismProjection;
import com.example.demo_ai.repository.ChunkRepository;
import lombok.RequiredArgsConstructor;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
@RequiredArgsConstructor
public class PlagiarismService {
    private final ChunkRepository chunkRepository;

    public List<PlagiarismInfo> checkPlagiarism(Long submissionId, double threshold) {
        List<PlagiarismProjection> results = chunkRepository.findTop3SimilarChunks(submissionId, threshold);

        return results.stream().map(p -> new PlagiarismInfo(
                null,
                p.getSourceChunkId(),
                p.getTargetChunkId(),
                p.getSourceFileName(),
                p.getTargetFileName(),
                p.getSourceChunkIndex(),
                p.getTargetChunkIndex(),
                p.getSimilarity(),
                p.getSimilarity() >= threshold,
                p.getSourceSubmissionId(),
                p.getTargetSubmissionId(),
                p.getSourceContent(),
                p.getTargetContent()
        )).toList();
    }
}
