
'use strict';
const videosDropdown = document.getElementById("Videos-Dropdown");


fetch("https://www.scorebat.com/video-api/v1/",
    {
    method: "GET",
    headers: { "Accept": "application/json" }
    })
    .then(response => response.json())
    .then(videoData => {
        for(const elem of videoData)
        {
            let newVideo = document.createElement("option");
            newVideo.innerHTML = elem.title;
            videosDropdown.appendChild(newVideo);
        }
        
    });
    


