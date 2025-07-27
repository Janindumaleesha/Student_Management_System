# Student_Management_System

+------------------+
|     Student      |
+------------------+
| - studentId:int  |
| - name:string    |
| - dob:Date       |
| - gender:string  |
| - email:string   |
| - phone:string   |
| - address:string |
+------------------+
| +enroll(course:Course):void     |
| +viewGrades():List<Grade>       |
+------------------+

          1
          |
          | 
          | Enrolls
          | 
          | *
+------------------+      *          1     +------------------+
|     Course       |---------------------->|     Teacher      |
+------------------+                       +------------------+
| - courseId:int   |                       | - teacherId:int  |
| - name:string    |                       | - name:string    |
| - code:string    |                       | - email:string   |
| - description:string|                   | - phone:string   |
| - credits:int    |                       +------------------+
+------------------+                       | +assignGrade():void|
| +addStudent():void|                      +------------------+
| +assignTeacher():void|
+------------------+

        1
        |
        | Has
        |
        | *
+------------------+
|     Grade        |
+------------------+
| - gradeId:int    |
| - student:Student|
| - course:Course  |
| - score:float    |
| - letterGrade:string|
+------------------+
| +calculateGPA():float|
+------------------+

        1
        |
        | Teaches
        |
        | *
+------------------+
|     Teacher      |
+------------------+
| - teacherId:int  |
| - name:string    |
| - email:string   |
| - phone:string   |
+------------------+
| +assignGrade():void|
| +getCourses():List<Course>|
+------------------+

🔍 Description of Each Class
1. Student
Attributes: ID, name, date of birth, gender, contact details.

Methods:

enroll(course) — enrolls in a course.

viewGrades() — view all grades.

2. Course
Attributes: ID, name, code, description, credits.

Methods:

addStudent() — adds a student to the course.

assignTeacher() — assigns a teacher to the course.

3. Teacher
Attributes: ID, name, email, phone.

Methods:

assignGrade() — assigns a grade to a student.

getCourses() — lists all courses taught by this teacher.

4. Grade
Attributes: ID, student, course, score, letter grade.

Methods:

calculateGPA() — calculates GPA based on grades.

🔧 What to Do in This Project (Project Workflow)
✅ 1. Requirements Gathering
Determine what features the system should support: student registration, course assignment, grading, etc.

✅ 2. Database Design
Tables for Students, Courses, Teachers, Grades.

Relationships:

Many-to-many between Students and Courses.

One-to-many between Teachers and Courses.

One-to-many between Courses and Grades.

✅ 3. Backend Development
Language: C#, Java, Python, or Node.js.

Use MVC pattern.

Implement:

CRUD for Student, Course, Teacher.

Enrollment logic.

Grade management and GPA calculation.

✅ 4. Frontend Development
Web interface using React, Angular, or plain HTML/CSS/JS.

Pages:

Student dashboard.

Course list.

Enrollment form.

Teacher grading panel.

✅ 5. Authentication (Optional but recommended)
Admin/Teacher/Student login with role-based access.

✅ 6. Testing
Unit tests for business logic.

Integration tests for enrollment and GPA.

✅ 7. Deployment
Host on local server or use services like Heroku, Vercel, Azure, etc.
