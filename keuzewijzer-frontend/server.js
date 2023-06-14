const https = require("https");
const fs = require("fs");
const express = require('express');
const path = require('path');
const mime = require('mime-types');
const cors = require('cors');

const app = express();
const port = process.env.PORT || 3000;

app.use('/dist/js', express.static(path.join(__dirname, 'dist/js')));

app.use(
    cors({
        origin: [`http://localhost:7298`],
        credentials: 'true',
    })
);

// Set content-type header for JS files explicitly
app.get('*.js', function(req, res, next) {
    res.set('Content-Type', mime.contentType('js'));
    next();
});

// Fallback route that returns index.html for any other request
app.get('*', (req, res) => {
    res.sendFile(path.join(__dirname, 'index.html'));
});


https.createServer(
    // Provide the private and public key to the server by reading each
    // file's content with the readFileSync() method.
    {
        key: fs.readFileSync("cert/key.pem"),
        cert: fs.readFileSync("cert/cert.pem"),
    },
    app).listen(3000, () => {
    console.log("server is running at port 3000");
});