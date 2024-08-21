# State Machine Examples
## trafficlight.scene
A simple scene showing how different state machines can interact with each other by sending messages.

Each of the 4 traffic lights has a state machine that handles cycling colours when receiving either a "red" or "green" message.

![sbox-dev_2SUVEb4Inj](https://github.com/user-attachments/assets/575f3713-3f00-413f-96e7-e887bef840e5)

A central state machine cycles the whole intersection between north / south and east / west traffic, sending messages to the state machines of each lamp.

https://github.com/user-attachments/assets/2e3eb877-d685-4f9f-8f6b-3dd2845b9b04
