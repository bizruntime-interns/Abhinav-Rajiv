const websck=require('ws');
const websktserver=new websck.Server({ port: 8080 });
websktserver.on('connection', (webSocket) => {
    webSocket.on('message', (message) => {
      console.log('Received:', message);
      broadcast(message);
    });
  });
  
  function broadcast(data) {
    websktserver.clients.forEach((client) => {
      if (client.readyState === websck.OPEN) {
        client.send(data);
      }
    });
  }
