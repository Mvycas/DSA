import time

# Start the timer
start_time = time.time()
total_start_time = time.time()

## Create array
array = list(range(150_000_000))
time_taken = time.time() - start_time
print(f"Time taken to create the list: {time_taken:.2f} seconds")

# Start the timer for the retrieval operation
start_time = time.time()
##retrieving element
element = array[750_000]
print(f"Element at index 750_000: {element}")
time_taken = time.time() - start_time
print(f"Time taken to retrieve the element: {time_taken:.2f} seconds")

# Start the timer for the insertion operation
start_time = time.time()
## Inserting an element in the middle
array.insert(560, 750_000)
print(f"Element inserted at index 560: {array[560]}")
time_taken = time.time() - start_time
print(f"Time taken to insert the element: {time_taken:.2f} seconds")


# Start the timer for the removal operation
start_time = time.time()
## Removing an element from the middle
array.remove(450_000)
print(f"Element 450_000 removed from the list.")
time_taken = time.time() - start_time
print(f"Time taken to remove the element: {time_taken:.2f} seconds")

# Measure the total time taken
total_time_taken = time.time() - total_start_time
print(f"Total time taken for all operations: {total_time_taken:.2f} seconds")