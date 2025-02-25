# Network Latency and Packet Loss Handling in Unity

This guide provides step-by-step instructions for how I implemented network latency and packet loss handling in my local co-op Unity game.

## Network Latency

### Client-Side Prediction
Create a script to handle player movement prediction
### Server Reconciliation
On the server, maintain the authoritative game state. This took me longer to understand for some reason.
Periodically send the game state to the client.
On the client, compare the predicted state with the server state and correct any discrepancies.

### Lag Compensation
Implement lag compensation by rewinding the game state to the time when the action was performed.
Use a buffer to store past game states.
When an action is received, rewind the game state to the appropriate time and apply the action.

### Packet Loss & Jitter
Network Simulator
Add the Network Simulator component to your project by installing the necessary packages:
Unity Transport (version 2.0.0)
Add the NetworkSimulator component to a persistent GameObject in your scene.
Configure the Network Simulator to simulate packet loss and jitter.

#### Error Correction
Implement error correction techniques to handle lost packets using acknowledgment (ACK) packets.
When a packet is sent, the sender waits for an acknowledgment from the receiver. If the acknowledgment is not received within a certain time frame, the sender retransmits the packet.
Use sequence numbers to keep track of packets and ensure they are processed in the correct order.

#### Buffering and Interpolation
Implement buffering to handle out-of-order packets and smooth out the effects of jitter.
Buffer incoming packets and process them in the correct order based on their sequence numbers.
Use interpolation to provide a smooth gameplay experience by estimating the position and state of game objects between received packets.
- For more detailed information and examples, refer to Unity's Network Simulator documentation and the Latency and Packet Loss guide.

- I double checked coding with Chatgpt to make sure they were working. Unity will help in a lot of the new implementation if coded right. Please keep in mind my game is a local co-op puzzle game, so many factors are to change further in development if needed.