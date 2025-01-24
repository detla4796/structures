# StructTask

This project is a C# console application that solves three tasks:

1. **Circles**: Determines the circle with the largest radius and outputs its center coordinates.
2. **Resident Profiles**: Finds two residents who live in different cities but have the same address.
3. **Student Profiles**: Identifies the oldest male student in a group of students.

---

## Project Structure

- **Program.cs**: The main file that runs the program and provides a menu to select a task.
- **CircleTask.cs**: Implementation of the circle task.
- **ResidentTask.cs**: Implementation of the resident profiles task.
- **StudentTask.cs**: Implementation of the student profiles task.

---


## Task Descriptions

### Task 1: Circles

The program requests data for `10 circles` (radius and center coordinates). It then finds the circle with the largest radius and outputs its center coordinates.

Example Output:

`Coordinates of the circle with the largest radius: X = 10, Y = 15`

---

### Task 2: Resident Profiles

The program automatically generates data for `100 residents` (last name, city, address). It then finds two residents who live in different cities but have the same address.

**Example Output:**

`Resident 1: Ivanov, City: Moscow`

`Resident 2: Petrov, City: Saint Petersburg`

`Address: Lenina Street, house 5, apartment 10`

---

### Task 3: Student Profiles

The program automatically generates data for `25 students` (last name, date of birth, gender). It then finds the oldest male student in the group.

**Example Output:**

`Oldest male student: Ivanov, Date of Birth: 15.3.1990`
