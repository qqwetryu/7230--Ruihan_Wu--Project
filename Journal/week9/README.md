# Ruihan-Wu_DECO7230_2025

This week, I tested my prototype and joined the evaluation.


Objective and validation metrics
This project (Inkroom) the testing goal of this time is to test whether users can smoothly understand and complete the basic process of document editing content inside the space, such as open keyboard, input text, close keyboard, save document, and during the whole process test the following objectives:

whether users understand the paper is an interactive object and can successfully trigger interaction;
whether users can understand the running method of the save system;
whether users can distinguish the function roles of left hand (control mode switch) and right hand (operate document).

At the same time observe whether users can complete the operation without extra guidance and without long time confusion and wrong interaction. And after completion through short interview get the evaluation of naturalness, clarity and interface comfort of the interaction process.

Results & Analysis
Testing Plan Summary

This testing uses MacBook connecting Meta Quest 3 as platform, testers in simulator environment complete interaction with bare hand gestures. The testing process is: left hand click paper wake up virtual keyboard; right hand click paper get blinking cursor prompt, start input; left hand click paper close keyboard; right hand drag paper to the right side of body save document.
The whole system interaction method supports hand tracking and completes inside VR space, testing time control within 5 minutes. And after finish make short interview questions, get usability answers and opinion evaluation.

Feedback Analysis
In this testing, participants generally feedback can understand the interaction method of left hand click paper to open virtual keyboard and right hand click enter typing mode and use. But facing through right hand drag paper to the right side complete save operation process. Users generally think such operation logic has a certain intuitiveness, especially on the save way got “natural”, “fit space understanding” positive evaluation. But at the same time, because the desktop place document this part lack obvious prompt and area division, some testers said at first time try interaction lack trust on this content.
Users to the testing content of “paper is interactive object” understanding is relatively clear, and in typing mode appear the vertical line cursor also helps to establish judgment of current state. However, in testing process also exposed some user experience problems. Some of the participants feedback at first enter typing state did not timely notice the appearance of cursor and exist confusion for trigger, in interaction exist repeated attempt to confirm whether operation succeed situation.
Overall, this round of testing helped us verify the current interaction logic in structure is understandable, but also pointed out there is still optimization space in spatial layout and feedback system. These feedback are of important reference value for subsequent iteration.


Evaluation of Aims-Testing Process & Reflection
In this testing process, the overall testing completion degree is good, most testers under not rely on too much prompt completed all operation. But this operation also exposed the shortage of this space in feedback mechanism and spatial layout, especially under high freedom scene of using Meta Quest headset, this prototype in hand gesture content reading and environment size limitation has obvious problems. For example, because the space position is small leading to paper mis-touch, the spatial layout not clear leading to the interaction direction not clear and so on. But in the whole development process, I also further understood the design logic and design method of spatial interaction content, specifically, is in the definition of space, not necessarily need to design exactly the same scene or operation method as the real world, need to carry out targeted guidance and content adjustment based on user needs.

Concept Iteration-Next Iteration Plan
After the summary of this round of testing feedback, I plan to carry out more specific optimization and the next step content enrichment plan. First, I will adjust the size of the paper and the trigger range, try to reduce the possibility of bug caused by gesture trigger mis-touch. Second, I will add prompt interactive feedback mechanism, design more explicit indicative prompt for keyboard assist user confirm state. At the same time, I will enhance the prompt part of save area, transform the “intuitiveness” of this area into more universal alternative option, improve the user confidence during space use process. And consider try to add virtual guiding information/animation in the scene, assist users quickly understand prototype and complete use.


![screen shoot - short interview answer](./img/111.png)