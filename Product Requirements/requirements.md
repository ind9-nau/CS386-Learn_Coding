# Project Requirements

_Team 7: CodeHub\
Febuary 13th, 2022\
Writers: Ricardo Chairez, Ian Dennis, Kelene Moore, Bailey Rosato, Nasya Valenzuela, Nicole Sylvester_


## 1. Positioning

### 1.1 Problem statement
The problem of accessing the world of computer programming affects the general population of learners, the impact of which is limiting their access to the modern world.

### 1.2. Product Position Statement
For anyone interested in learning about coding CodeHub is a free education application that lets you learn the basics of computer literacy and programming at your own pace. Unlike CodeHS, our product allows users to work in groups and is available to everyone. 

### 1.3. Value proposition
CodeHub is a free, self-paced programming education web- application designed to teach coding to all ages at any level of coding experience. 

**Consumer segments:**
- School Districts
- Teachers/ Other Educators
- Early education for K-12 students 
- Supplemental Education for high school and college students 
- Self-paced Learners 
- Employee Training 
- Small Businesses 
- Hobbyist 
- Gamers and Modders 

## 2. Stakeholders
**Users** – Teachers, students, self-paced learners, employees, small businesses\
**Competitors** – CodeHS, Khan academy, CodeAcademy \
**Detractors** – Formal classes \
**Developers** - Ricardo Chairez, Ian Dennis, Kelene Moore, Bailey Rosato, Nicole Sylvester, Nasya Valenzuela 

## 3. Functional requirements (features)
- Work in groups (Teams) 
  - Small groups to collaborate in a project 
  - Moderator Role(“Teacher”) 
    - Can see progress/grade assignments 
    - Can manage community hub, delete comments, ban people 
- Community Hub/Q&A forum 
- Pretest/Placement tests 
- Open ended projects 
- Customizable profiles 
- Reminders 
- Rewards/Ranking system 
  - Streak tracker   
  - Mentor “rank” 
- Tutorials and Reference videos 
- Orientation/reference for programming 
  - How different languages are used 
  - Where to find more resources 
  - Computer architecture 101 
  - Etc.
   
## 4. Non-functional requirements
- Ease of use 
- Availability 
- Compatibility  
- Description of every function on application 
- Toggling options for all “extra” features 
  - I.e. rankings, chats, group work 
- Videos aren’t more than 15 minutes each 

## 5. MVP
- The features we plan to implement early on include three beginner courses (python, java, and web dev)  
  - Basic in-app IDE for each course 
- Two larger, open-ended projects for each course 
- Computer literacy pseudo-course 
  - Lots of explanations along with basic exercises 
- Q&A forum 
- Basic achievements 
  - Courses completed 
  - Days in a row practiced 
  - Questions asked/answered in forum 
- Reminder emails 
- User profiles/accounts 
  - Including basic settings menu 
  
**Testing:**
- WOZ for user interface and interactions 
- Direct implementation for all other features

## 6. Use cases

### 6.1. Use case diagrams
<img alt="image" src="https://user-images.githubusercontent.com/71862426/153727318-0a3d02e0-d705-43e1-8377-c0d23bb8b537.png">

### 6.2. Use case descriptions
**Use Case**: Manage Community Hub\
**Actor**: Moderator\
**Description**: Moderator can delete, ban, and community posts/profiles as appropriate.\
**Preconditions**: Must have downloaded application and have a moderator profile.\
**Postconditions**: Normal user account will be changed as outlined in description. The community hub has been updated to reflect these descriptions\
**Main Flow**:
1. Case begins when Moderator visits the community hub.
2. Moderator views an outstanding community post or profile.\
  **Alternative Flow 1:**\
  a. The post observed by the moderator is exceptionally helpful or relevent.\
  b. The Moderator marks the post with a commendation.\
  **Alternative Flow 2:**\
  a. The post observed by the moderator is derogatory, irrelevent, or violates other community guidelines not listed here.\
  b. The Moderator removes the post from the community hub.\
  c. The Moderator messages the owner of the post with a warning and a description of why their post was removed.\
  **Alternative Flow 3:**\
  a. The User observed by the Moderator has been consistenly active and helpful in the community.\
  b. The Moderator awards the user with commendations.\
  **Alternative Flow 4:**\
  a. The User observed by the Moderator has consitently violated the community guidelines.\
  b. The Moderator permantently bans or temporarily suspends the User's community access.\
  c. The Moderator messages the owner of the post with a warning and description of why their account access was modified.
3. End use case. 

**Use Case**: Participate in a Community Hub\
**Actor**: User\
**Description**: Users will be able to submit forum posts and responses to a community hub.\
**Preconditions**: User must have application downloaded and thier profile must be verfied to be run by a person.\
**Postconditions**: User will become an active participant of the community hub.\
**Main Flow**:
1. User navigates to community hub location on application.
2. User creates a community post or adds to a post that has already been created.
3. End use case

**Use Case**: Join a team\
**Actor**: User\
**Description**: Users can join a team to collaborate on projects.\
**Preconditions**: User must have application downloaded and have a profile created.\
**Postconditions**: User will become an active participant of a team.\
**Main Flow**:
1. User chooses a set of users to be in a team with.
2. User collaborates with other members of the team to complete a project.
3. End use case.

**Use Case**: Start a project\
**Actor**: User\
**Description**: Users can start a project to work on.\
**Preconditions**: User must have application downloaded and have a profile created.\
**Postconditions**: User will have a saved project.\
**Main Flow**:
1. The use case begins when the user chooses a project to work on.  
2. User watches tutorial video.  
3. User can begin writing code in the IDE.\
   **Alternative flow**: User chooses to exit out of the current project to work on something else.  
4. User can switch between different projects.  
5. User can save work and access the project whenever.  
6. Use case ends.\
  
 
**Use Case**: Customize profile\
**Actor**: User\
**Description**: Users will be able to change the layout of the application and what/how information in their account is publicly displayed.\
**Preconditions**: Downloaded application and have a profile.\
**Postconditions**: The user now has a personalized interface.\
**Main Flow**:
1. The use case begins when the user accesses the settings.
2. The user can access privacy settings to choose what personal information is displayed on their profile.\
   **Alternate Flow**: User does not change the default settings.\
   a. Use case resumes at step 5.
3. The user can access layout settings and choose colors and layout schemes.\
   **Alternate Flow**: The user likes the default layout and does not change layout settings.\
   a. Use case resumes at step 5.
4. The user saves the changes.
5. The use case ends.

**Use Case**: Grade coding assignments\
**Actor**: Moderator\
**Descriptions**: Moderator will ensure users who do the coding projects have accomplished them correctly and provide appropriate feedback. \
**Preconditions**: Downloaded application, created a profile as a moderator, and have a team.\
**Postconditions**: User will have graded assignments.\
**Main Flow**:
1. The use case begins when the moderator’s team starts an assignment 
2. Moderator can see each person's progress and grade/comment on what they have done \
   **Alternative flow 1**: Person hasn’t started an assignment, moderator can give a “to-do” grade
3. End use case

## 7. User stories

**User story 1**:“As a user, I want to read about the purpose of programming languages first so I can learn the one that suites my needs.” \
Priority: 2 Hours: 3 

**User story 2**:“As a user, I want there to be a community hub so I can communicate with others and ask questions.” \
Priority: 1 Hours:  20 

**User story 3**:“As a user, I want to customize my profile so that the webapp is personalized to my style.” \
Priority: 1 Hours: 13 

**User story 4**:“As a user, I want the option to jump straight to higher level content, so I don’t feel my time is wasted.” \
Priority: 2 Hours: 8 

**User story 5**:“As a moderator, I want to be able to track and manage the people I’m helping so that I know they are learning the content.” \
Priority: 2 Hours: 10 

**User story 6**:“As a user, I want tutorial videos and manuals so I can learn about programming before trying to implement it.” \
Priority: 3 Hours: 5

**User story 7**:“As a user, I want to receive notifications, so I don’t forget to practice.” \
Priority: 1 Hours: 7 

**User story 8**:“As a user, I want to be able to work in small teams so that I am better prepared for an industry job.” \
Priority: 3 Hours: 9 

**User story 9**:“As a user, I want there to be able to share and compare my progress with other users so that I have another way to interact with the community.” \
Priority: 3 Hours: 10 

**User story 10**:“As a moderator, I want to be able to delete community posts and ban users so I can help maintain the CodeHub community.” \
Priority: 1 Hours: 10 

**User story 11**:“As a user, I want a basic settings menu to easily navigate the webapp.” \
Priority: 1 Hours: 5 

**User story 12**:“As a user, I want to be able to achieve an experienced programmer rank so I can help those still learning.” \
Priority: 3 Hours: 8 

## 8. Issue tracker
**GitHub**![Screenshot (45)](https://user-images.githubusercontent.com/71862426/153727669-baf0c856-3fe8-4e6e-9bcc-6ec5be589111.png)

