package com.example.demo_ai;

import com.example.demo_ai.service.EmbeddingService;
import lombok.RequiredArgsConstructor;
import org.springframework.boot.CommandLineRunner;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.context.annotation.Bean;

import java.io.File;
import java.util.Objects;

@SpringBootApplication
@RequiredArgsConstructor
public class DemoAiApplication {
	private final EmbeddingService embeddingService;

	public static void main(String[] args) {
		SpringApplication.run(DemoAiApplication.class, args);
	}

	@Bean
	CommandLineRunner commandLineRunner() {
		return args -> {
			System.out.println("Application started successfully!");
			File folder = new File("code/");
            for (File project : Objects.requireNonNull(folder.listFiles())) {
				embeddingService.saveSubmission(project);
			}
		};
	}
}
