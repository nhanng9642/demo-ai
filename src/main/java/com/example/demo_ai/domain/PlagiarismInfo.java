package com.example.demo_ai.domain;

import jakarta.persistence.*;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

@Getter
@Setter
@NoArgsConstructor
@AllArgsConstructor
public class PlagiarismInfo {
    private Long id;

    private Long sourceChunkId;
    private Long targetChunkId;

    private String sourceFileName;
    private String targetFileName;

    private int sourceChunkIndex;
    private int targetChunkIndex;

    private double similarityScore;
    private boolean isPlagiarized;

    private Long sourceSubmissionId;
    private Long targetSubmissionId;
    
    @Column(columnDefinition = "TEXT")
    private String sourceContent;

    @Column(columnDefinition = "TEXT")
    private String targetContent;
}
