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

# Sorting Algorithms Comparison

This project demonstrates the implementation and performance analysis of six common sorting algorithms. The dataset consists of 474 two-digit scores stored in `scores.txt`. Each algorithm is explained, and its performance is analyzed using real execution times.

---

## Table of Contents
- [Bubble Sort](#bubble-sort)
- [Insertion Sort](#insertion-sort)
- [Selection Sort](#selection-sort)
- [Heap Sort](#heap-sort)
- [Quick Sort](#quick-sort)
- [Merge Sort](#merge-sort)

---

## Bubble Sort
### Description
Bubble Sort repeatedly steps through the list, compares adjacent elements, and swaps them if they are in the wrong order. The process repeats until the list is sorted.

### Asymptotic Notation
- **Best Case**: O(n) (when the array is already sorted)
- **Worst Case**: O(n²) (when the array is sorted in reverse order)

### Pseudocode
BubbleSort(array):
    for i = 0 to length(array) - 1:
        for j = 0 to length(array) - i - 1:
            if array[j] > array[j + 1]:
                swap(array[j], array[j + 1])
### Performance
Execution Time: 1 ms

## Insertion Sort
### Description
Insertion Sort builds a sorted array one element at a time by repeatedly picking the next element and inserting it into its correct position.

### Asymptotic Notation
Best Case: O(n) (when the array is already sorted)
Worst Case: O(n²) (when the array is sorted in reverse order)

### Pseudocode
InsertionSort(array):
    for i = 1 to length(array) - 1:
        key = array[i]
        j = i - 1
        while j >= 0 and array[j] > key:
            array[j + 1] = array[j]
            j = j - 1
        array[j + 1] = key

### Performance
Execution Time: 0 ms

## Selection Sort
### Description
Selection Sort repeatedly finds the smallest (or largest) element from the unsorted part of the array and moves it to the sorted part.

### Asymptotic Notation
Best Case: O(n²)
Worst Case: O(n²)

### Pseudocode
SelectionSort(array):
    for i = 0 to length(array) - 1:
        minIndex = i
        for j = i + 1 to length(array) - 1:
            if array[j] < array[minIndex]:
                minIndex = j
        swap(array[i], array[minIndex])

### Performance
Execution Time: 0 ms

## Heap Sort
### Description
Heap Sort uses a binary heap data structure to repeatedly extract the maximum element and build a sorted array.

### Asymptotic Notation
Best Case: O(n log n)
Worst Case: O(n log n)

### Pseudocode
HeapSort(array):
    BuildMaxHeap(array)
    for i = length(array) - 1 to 1:
        swap(array[0], array[i])
        Heapify(array, 0, i)

Heapify(array, i, size):
    largest = i
    left = 2 * i + 1
    right = 2 * i + 2
    if left < size and array[left] > array[largest]:
        largest = left
    if right < size and array[right] > array[largest]:
        largest = right
    if largest != i:
        swap(array[i], array[largest])
        Heapify(array, largest, size)

### Performance
Execution Time: 0 ms

## Quick Sort
### Description
Quick Sort is a divide-and-conquer algorithm that partitions the array around a pivot element and recursively sorts the subarrays.

### Asymptotic Notation
Best Case: O(n log n)
Worst Case: O(n²) (when the pivot is poorly chosen)
### Pseudocode
QuickSort(array, low, high):
    if low < high:
        pi = Partition(array, low, high)
        QuickSort(array, low, pi - 1)
        QuickSort(array, pi + 1, high)

Partition(array, low, high):
    pivot = array[high]
    i = low - 1
    for j = low to high - 1:
        if array[j] < pivot:
            i = i + 1
            swap(array[i], array[j])
    swap(array[i + 1], array[high])
    return i + 1

### Performance
Execution Time: 0 ms

## Merge Sort
### Description
Merge Sort is a divide-and-conquer algorithm that splits the array into halves, recursively sorts each half, and merges them.

### Asymptotic Notation
Best Case: O(n log n)
Worst Case: O(n log n)

### Pseudocode
MergeSort(array):
    if length(array) > 1:
        mid = length(array) / 2
        left = array[0:mid]
        right = array[mid:]
        MergeSort(left)
        MergeSort(right)
        Merge(array, left, right)

Merge(array, left, right):
    i = 0, j = 0, k = 0
    while i < length(left) and j < length(right):
        if left[i] <= right[j]:
            array[k] = left[i]
            i = i + 1
        else:
            array[k] = right[j]
            j = j + 1
        k = k + 1
    while i < length(left):
        array[k] = left[i]
        i = i + 1
        k = k + 1
    while j < length(right):
        array[k] = right[j]
        j = j + 1
        k = k + 1

### Performance
Execution Time: 0 ms

# How to Run
Clone the repository.
Place scores.txt in the data folder.
Compile and run the application in a C# environment.
The console will display the sorted results, color-coded by score range, and the execution time for each algorithm.
