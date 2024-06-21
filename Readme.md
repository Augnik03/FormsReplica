# Desktop Application Setup Instructions

This repository contains a Windows Forms Application for viewing and creating submissions. Follow the steps below to set up and run the application locally.

## Prerequisites

- Visual Studio installed on your machine.
- .NET Framework installed on your machine.

## Installation

1. Clone this repository to your local machine:

   ```bash
   git clone https://github.com/Augnik03/FormsReplica.git
   ```

2. Open the solution file (`FormsReplica.sln`) in Visual Studio.

3. Restore the NuGet packages:
   - **Automatically**:
     - Open the solution in Visual Studio.
     - Visual Studio will prompt you to restore the NuGet packages if they are missing. Click "Restore" on the notification at the top of the IDE.
   - **Manually**:
     - Right-click on the solution in the Solution Explorer.
     - Select `Manage NuGet Packages for Solution...`.
     - In the NuGet Package Manager, click the `Restore` button to download and install the necessary packages.

## Application Description

The application consists of two main forms:

### Main Form

- **View Submissions Button**: Opens the "View Submissions" form.
- **Create New Submission Button**: Opens the "Create New Submission" form.

### View Submissions Form

- **Previous Button**: Navigates to the previous submission.
- **Next Button**: Navigates to the next submission.
- **Submission Details**: Displays the details of the current submission (Name, Email, Phone Number, GitHub Link, Stopwatch Time).

### Create New Submission Form

- **Editable Fields**: Fields for Name, Email, Phone Number, and GitHub Repo Link.
- **Stopwatch Button**: Resumes and pauses a stopwatch. Note that the stopwatch does not reset to 0 every time it is paused.
- **Submit Button**: Submits the details to the backend.

## Keyboard Shortcuts

- **Ctrl + V**: Opens the "View Submissions" form from the main form.
- **Ctrl + C**: Opens the "Create New Submission" form from the main form.
- **Ctrl + P**: Navigates to the previous submission in the "View Submissions" form.
- **Ctrl + N**: Navigates to the next submission in the "View Submissions" form.
- **Ctrl + S**: Submits the form in the "Create New Submission" form.

## Running the Application

1. Build the solution in Visual Studio:

   ```bash
   Build > Build Solution
   ```

2. Run the application:

   ```bash
   Debug > Start Debugging
   ```

3. Use the main form to navigate between viewing and creating submissions.

## Backend Integration

The application is integrated with a backend server for storing and retrieving submissions. Make sure the backend server is running and accessible at the specified endpoint before using the application.

### Fetching Submissions

The "View Submissions" form fetches submissions from the backend server and displays them one by one using the Previous and Next buttons.

### Creating Submissions

The "Create New Submission" form submits the new submission details to the backend server.

---

