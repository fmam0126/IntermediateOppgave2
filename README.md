# Test Repository for [Oppgave 1](https://github.com/fmam0126/OppgaveGeneriskeTyper)

in this repository, you will find test code for the generic types assignment.

It tests the following classes:

- `Repository<T>`
- `CustomStack<T>`

## What is Tested

- `Repository<T>`:
  - `Add(T item)` - Adding items to the repository
  - `Remove(T item)` - Removing items from the repository
  - `GetAll()` - Retrieving all items
  - `FindById(int id)` - Finding items by their ID

- `CustomStack<T>`:
  - `Push(T item)` - Pushing items onto the stack
  - `Pop()` - Popping items from the stack

The tests check if the methods work as expected, including edge cases such as adding duplicate items, removing non-existent items, and retrieving items by ID.

## Test Coverage & Design Decisions

### Why these tests?

These tests were created to verify that the core functionality of both classes works correctly. The `Repository<T>` tests ensure that items can be added, removed, and retrieved both individually and as a collection. The `CustomStack<T>` tests verify the fundamental stack operations (LIFO - Last In, First Out).

### Coverage of basic functionality

The tests cover the essential functionality of each class:

- **Repository**: Basic CRUD operations (Create, Read, Update, Delete)
- **CustomStack**: Core stack operations (Push and Pop)

Edge cases are also tested, such as:

- Adding duplicate items
- Removing items that don't exist
- Finding items by non-existent IDs

### Can another developer understand the implementation through these tests?

Yes, the tests serve as documentation for how to use both classes. Each test method is named descriptively making it clear what behavior is expected.
