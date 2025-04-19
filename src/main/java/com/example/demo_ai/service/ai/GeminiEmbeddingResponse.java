package com.example.demo_ai.service.ai;

import lombok.Getter;
import lombok.Setter;

import java.util.List;

@Getter
@Setter
public class GeminiEmbeddingResponse {
    private List<EmbeddingVector> embeddings;

    public float[] getEmbeddingVector(int index) {
        if (embeddings != null && index < embeddings.size()) {
            List<Float> values = embeddings.get(index).getValues();
            float[] floatArray = new float[values.size()];
            for (int i = 0; i < values.size(); i++) {
                floatArray[i] = values.get(i);
            }
            return floatArray;
        }
        return null;
    }
    @Getter
    @Setter
    private static class EmbeddingVector {
        private List<Float> values;
    }
}
