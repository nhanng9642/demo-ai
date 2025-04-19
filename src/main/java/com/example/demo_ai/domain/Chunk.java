package com.example.demo_ai.domain;

import jakarta.persistence.*;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;
import org.hibernate.annotations.Array;
import org.hibernate.annotations.JdbcTypeCode;
import org.hibernate.type.SqlTypes;

import java.io.File;

@Entity
@Getter
@Setter
@NoArgsConstructor
public class Chunk {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    Long id;

    Long submissionId;

    String fileName;

    int chunkIndex;

    @Column(columnDefinition = "TEXT")
    String content;

    @Column(name = "embedding")
    @JdbcTypeCode(SqlTypes.VECTOR)
    @Array(length = 768)
    private float[] embedding;

    public Chunk(File file, Long submissionId, int i, String string) {
        this.submissionId = submissionId;
        this.fileName = file.getName();
        this.chunkIndex = i;
        this.content = string;
    }
}
