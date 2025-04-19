package com.example.demo_ai.controller;

import com.example.demo_ai.domain.PlagiarismInfo;
import com.example.demo_ai.service.PlagiarismService;
import lombok.RequiredArgsConstructor;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/api/plagiarism")
@RequiredArgsConstructor
public class PlagiarismController {

    private final PlagiarismService plagiarismService;

    @GetMapping("/check/{submissionId}")
    public ResponseEntity<List<PlagiarismInfo>> checkPlagiarism(
            @PathVariable Long submissionId,
            @RequestParam(defaultValue = "0.8") double threshold
    ) {
        List<PlagiarismInfo> result = plagiarismService.checkPlagiarism(submissionId, threshold);
        return ResponseEntity.ok(result);
    }
}