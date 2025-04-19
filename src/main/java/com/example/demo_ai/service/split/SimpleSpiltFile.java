package com.example.demo_ai.service.split;

import com.example.demo_ai.domain.Chunk;
import org.springframework.stereotype.Component;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

@Component
public class SimpleSpiltFile implements FileService {
    static final int MAX_CHUNK_SIZE = 3000;

    @Override
    public List<Chunk> split(File file, Long submissionId) {
        List<Chunk> chunks = new ArrayList<>();

        try (BufferedReader reader = new BufferedReader(new FileReader(file))) {
            StringBuilder chunkContent = new StringBuilder();
            String line;
            int chunkIndex = 0;

            while ((line = reader.readLine()) != null) {
                if (chunkContent.length() + line.length() > MAX_CHUNK_SIZE) {
                    Chunk chunk = new Chunk(file, submissionId, chunkIndex++, chunkContent.toString());
                    chunks.add(chunk);
                    chunkContent.setLength(0);
                }
                chunkContent.append(line).append("\n");
            }

            if (!chunkContent.isEmpty()) {
                Chunk chunk = new Chunk(file, submissionId, chunkIndex, chunkContent.toString());
                chunks.add(chunk);
            }

        } catch (IOException e) {
            e.printStackTrace();
        }

        return chunks;
    }
}
