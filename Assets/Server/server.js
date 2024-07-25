const express = require('express');
const app = express();
const PORT = 3000;

app.get('/relay', (req, res) => {
    const playerInput = req.query.playerinput;
    console.log(`Received player input: ${playerInput}`);
    res.send(`Received player input: ${playerInput}`);
});

app.listen(PORT, () => {
    console.log(`Server is running on http://localhost:${PORT}`);
});
