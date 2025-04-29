# Local Co-op Puzzle Game

## Description
This is a cooperative puzzle game built using Unity, designed for local multiplayer experiences. Players must work together to solve challenges, navigate obstacles, and unlock new areas through teamwork and problem-solving.

## Multiplayer Details
- **Player Count:** The game supports **2 playrtd** in a local co-op setup of arrows and keys. Share a Laptop.
- **Multiplayer Type:** The game is purely **cooperative**, encouraging players to collaborate to complete puzzles.

## Lag & Latency Management
Since the game is local co-op, network latency is minimal. However, we ensure smooth gameplay by:
- Optimizing game loops and physics calculations for consistent frame rates.
- Utilizing Unity's built-in performance profiling tools.
- Ensuring responsive local input handling to eliminate noticeable delays.

## Security Considerations
- The game integrates **Google Token-based login** for user authentication.
- Player data is something i'm wanting to incorporate. IfI can utilize Unity more. 

## Multi-Factor Authentication (MFA)
- **Google Token Authentication** with optional MFA settings ( app-based authentication).
- Encouraging users to enable **Google Authenticator** or similar services for additional security.

## Data Storage
- **Player Progress:** Level completion and wanting to incoporate achievements.
- **Settings & Preferences:** UI customizations, control mappings, and accessibility features.
- **Login Credentials:** Securely stored authentication tokens for seamless sign-ins using google. Will need to test continuos as google upgrade.

## Project Timeline
| Estimated complitation- 1 Year|
| Planning | Game design & feature scoping | 2 Month |
| Development | Core gameplay mechanics | 5 Months |
| Testing | Bug fixes, optimization & QA | 5 Month |
| Release | Deployment & post-launch support | Ongoing |

## Project Management System
I want to utilize **Jira/Trello** for task tracking and **Slack** for team communication. However I still not feel confindent in my ability to get coding to work properly. 

## Central Repository
- GitHub
- Git workflows ensure efficient branching and merging. Plus I'm mostly familiar with github, and its free for most of my coding. 
