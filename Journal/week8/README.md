# Ruihan-Wu_DECO7230_2025

This week, I continued to refine my second prototype based on the issues discovered during the earlier stages of testing.

The main focus was to troubleshoot the bug where the paper document couldn't be grabbed or interacted with properly inside the XR environment. After multiple attempts, I finally realised that the issue wasn't with the interaction script, but with the overall model scale—the entire scene and document were too large, which made it impossible for the virtual hands to trigger colliders or interact areas effectively.

To fix this, I made several adjustments:

Rescaled the XR scene and repositioned the paper models to bring them closer to the user’s default view.

Adjusted the interaction distance and collider sensitivity, which finally enabled the grab gesture to work correctly again.

Conducted internal trials to test the improvements and stability of the paper grabbing and text input features.

Additionally, I prepared for the upcoming Week 9 user testing. I successfully learned how to:

Record footage from Meta Quest 3,

Transfer the recordings to my MacBook,

And check playback to ensure the interactions are properly captured.

Overall, this week was very hands-on and focused on technical polishing and spatial fine-tuning, ensuring that the prototype is now fully functional for testing in both grabbing and typing aspects. I’m now ready to collect user feedback and iterate further.

This week’s development process was both technically challenging and deeply enlightening. What initially seemed like a minor interaction bug—users being unable to grab the document—revealed itself to be rooted in spatial design issues.

After careful observation and testing, I discovered that the oversized environment scale was interfering with the VR hand gesture recognition. This insight helped me realise that in immersive design, scale is not just visual—it’s functional. When proportions are off, even well-scripted interactions can fail completely. This was a powerful reminder that designing for XR requires constant testing in context, rather than relying solely on Unity's editor view.

The debugging process also trained me to think more critically about user ergonomics and system feedback. When the document couldn't be grabbed, there was no error message or feedback—just silence. This led me to consider the importance of communicating system states to users (e.g., through visual cues or haptic hints), which I aim to implement in future iterations.

Moreover, the experience of preparing for formal user testing taught me new skills like recording and exporting video from Meta Quest 3, managing test files, and validating interaction footage. These may seem technical, but I see them as part of a broader design responsibility: making sure the experience not only works but can also be evaluated, communicated, and improved.

This reflection has helped me understand that meaningful iteration doesn’t just come from building—it comes from observing failure, identifying invisible causes, and taking technical ownership of the design. I feel more confident now in balancing creative intent with technical feasibility, and I’m excited to see how this will shape the next round of user testing.

![screen record](./img/888.png)