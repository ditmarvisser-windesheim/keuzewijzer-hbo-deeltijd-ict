## Domeinmodel

``` mermaid
classDiagram
  Business --> User
  Business "1" -- "0..*" JobOffer : Uses
  Applicant --> User
  User "1" -- "0..*" Preferences : Uses multiple
  JobOffer --> Job
  JobOffer "1" -- "0..*" Matches : Uses multiple
  JobApplication --> Job
  JobApplication "1" -- "0..*" Matches : Uses multiple

  class Business{
    - business page
  }

  class User{
    - name
    - address information
    - email
    - username
    - password
  }
  
  class Applicant{
    - availability
    - curriculum vitea
  }
  
  class Preferences{
    - name
  }
  
  class JobOffer{
    - description
    - wage offer
  }
  
  class Job{
    - name
    - location
    - branche
    - hours
    - wage
  }
  
  class JobApplication{
    - location range
    - payment range
  }
  
  class Matches{
    - chat messages
    - appointment date
  }
```

## Sequence Diagram: Swiping
``` mermaid
sequenceDiagram
  actor User 
  participant UI 
  participant System 
  User->>UI: Open swiping page 
  activate User 
  activate UI 
  activate System 
  UI->>System: Get list of matches 
  System->>db:Request potential matches 
  activate db 
  db->>System:Return list of potential matches 
  deactivate db 
  loop if potential matches available 
  System->>UI:Return potential match 
  UI->>User:Show potential match 
  User->>UI:Swipe left 
  User->>UI:Swipe right 
  UI->>System: Update match 
  System->>db:Update match 
  activate db 
  System->>db:Check if doublesided match 
  alt If succesful match 
  db->>System:Return true 
  deactivate db 
  System->>UI:Return true 
  activate UI 
  UI->>User:Show succesful match 
  activate User 
  User->>UI:Click "Chat" 
  UI->>User:Show chat page 
  User->>UI:Click 'Keep swiping' 
  deactivate System
  deactivate UI 
  deactivate UI 
  deactivate User 
  deactivate User 
  end 
  end 
```