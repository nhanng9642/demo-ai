package com.example.demo_ai.domain;

public interface PlagiarismProjection {
    Long getSourceChunkId();
    Long getTargetChunkId();
    Long getSourceSubmissionId();
    Long getTargetSubmissionId();
    String getSourceFileName();
    String getTargetFileName();
    int getSourceChunkIndex();
    int getTargetChunkIndex();
    String getSourceContent();
    String getTargetContent();
    double getSimilarity();
}
