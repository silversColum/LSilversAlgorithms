# Algorithms Class Projects
This repository contains the projects and assignments completed for my Algorithms class. Through these projects, I explored various algorithmic concepts, data structures, and problem-solving techniques, gaining a deeper understanding of efficiency and practical implementation.

## Table of Contents
Projects Overview
1. Fisher-Yates Shuffle (War Card Game)
2. Bag Iterator Assignment
3. Maze Game (O(N^2) and O(2^N) Logic)
4. Connect 4 Game Logic
Lessons Learned
## Projects Overview
### 1. Fisher-Yates Shuffle (War Card Game)
In this assignment, I implemented the Fisher-Yates Shuffle to randomize the deck for a War card game. The Fisher-Yates algorithm is an efficient way to shuffle an array in O(N) time. Instead of using common but less efficient methods like random swaps in loops, this approach ensures uniform randomness by iterating through the deck from the end to the start, swapping each element with a randomly selected element before it.

Key Learnings:
The Fisher-Yates Shuffle prevents biased shuffling by using each element exactly once in the swap process.
Understanding how an O(N) shuffle can be more efficient and fair compared to other naive shuffling methods like repeatedly random swaps.

### 2. Bag Iterator Assignment
This assignment required implementing an iterator for a custom data structure called a "Bag." The Bag is similar to a list but allows duplicates and has no specific order.

Key Learnings:
Iterators are a powerful tool for traversing data structures, providing a way to access elements without exposing the underlying implementation.
Implementing the Bag Iterator deepened my understanding of iterator design patterns and helped solidify the concept of encapsulation.
I also practiced using yield return in C#, making the iteration more efficient by lazily evaluating the next element.

### 3. Maze Game (O(N²) and O(2^N) Logic)
For my maze game project, I worked with different algorithmic approaches to solve the maze:
O(N²) Logic: A straightforward approach using a 2D array to represent the maze. I implemented a breadth-first search (BFS) to find the shortest path from the start to the goal, which has a time complexity of O(N²).
O(2^N) Logic: I explored recursive backtracking to find all possible paths in the maze. This approach, while less efficient, was useful for understanding exponential growth in algorithm complexity and the challenges of solving problems with a large state space.

Key Learnings:
Comparing the efficiency of BFS versus recursive backtracking provided a clear demonstration of how different algorithms can impact performance based on the input size.
The project helped me appreciate the importance of choosing the right algorithm based on the problem constraints.

### 4. Connect 4 Game Logic
In this project, I implemented the logic for the classic game Connect 4, focusing on how to efficiently check for a win condition (4-in-a-row horizontally, vertically, or diagonally).

Key Learnings:
Implementing the win-check logic gave me experience with 2D array traversal and understanding pattern recognition in data structures.
I learned how to optimize the win-check to avoid redundant checks, making the solution more efficient by only examining newly placed pieces rather than scanning the entire board.
Lessons Learned
Throughout these assignments, I gained significant insights into:
The importance of understanding algorithmic efficiency and the difference between linear, quadratic, and exponential time complexities.
How to implement common data structure patterns, such as iterators and shuffling algorithms, in a way that is both efficient and easy to understand.
The trade-offs between performance and simplicity in different algorithmic approaches and how these trade-offs can impact the user experience in game development.
These projects were an excellent opportunity to apply theoretical concepts in practical scenarios, reinforcing my knowledge and problem-solving skills in algorithms.
