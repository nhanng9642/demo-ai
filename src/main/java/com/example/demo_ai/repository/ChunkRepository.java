package com.example.demo_ai.repository;

import com.example.demo_ai.domain.Chunk;
import com.example.demo_ai.domain.PlagiarismProjection;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public interface ChunkRepository extends JpaRepository<Chunk, Long> {

    @Query(value = """
        SELECT *
        FROM (
            SELECT
                c1.id AS source_chunk_id,
                c2.id AS target_chunk_id,
                c1.submission_id AS source_submission_id,
                c2.submission_id AS target_submission_id,
                c1.file_name AS source_file_name,
                c2.file_name AS target_file_name,
                c1.chunk_index AS source_chunk_index,
                c2.chunk_index AS target_chunk_index,
                c1.content AS source_content,
                c2.content AS target_content,
                1 - (c1.embedding <=> c2.embedding) AS similarity,
                ROW_NUMBER() OVER (PARTITION BY c1.id ORDER BY c1.embedding <=> c2.embedding) AS rn
            FROM chunk c1
            JOIN chunk c2
                ON c1.submission_id = :submissionId
                AND c2.submission_id <> :submissionId
        ) ranked
        WHERE ranked.rn <= 3
          AND ranked.similarity >= :similarityThreshold
        ORDER BY ranked.source_chunk_id, ranked.similarity DESC;
        """, nativeQuery = true)
    List<PlagiarismProjection> findTop3SimilarChunks(@Param("submissionId") Long submissionId,
                                                     @Param("similarityThreshold") double similarityThreshold);
}
