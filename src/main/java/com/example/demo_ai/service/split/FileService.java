package com.example.demo_ai.service.split;

import com.example.demo_ai.domain.Chunk;
import net.lingala.zip4j.ZipFile;

import java.io.*;
import java.nio.file.Files;
import java.nio.file.Path;
import java.util.List;

public interface FileService {
    String SUBMISSION_PATH = "submissions";
    String[] CODE_EXTENSIONS = {".java", ".py", ".js", ".cpp", ".c", ".cs", ".go", ".rb", ".php"};

    List<Chunk> split(File file, Long submissionId);

    default Path unzipFile(File file)  {
        Path outputDir = Path.of(SUBMISSION_PATH, file.getName().replace(".zip", ""));
        try {
            Files.createDirectories(outputDir);
            new ZipFile(file).extractAll(outputDir.toString());
        } catch (IOException e) {
            e.printStackTrace();
        }

        return outputDir;
    }

    static boolean isCodeFile(Path file) {
        for (String ext : CODE_EXTENSIONS) {
            if (file.toString().endsWith(ext)) {
                return true;
            }
        }
        return false;
    }
}
