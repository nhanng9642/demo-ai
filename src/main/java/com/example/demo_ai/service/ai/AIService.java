package com.example.demo_ai.service.ai;

import com.example.demo_ai.domain.Chunk;

import java.util.List;

public interface AIService {
    void getEmbeddingVector(List<Chunk> chunks);
}
