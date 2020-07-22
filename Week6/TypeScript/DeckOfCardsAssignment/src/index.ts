//import Deck from "./deck";
//import Card from "./card";

const drawButton = document.getElementById("draw-button");

if(drawButton)
{
    drawButton.addEventListener("click", DrawCard);
}


// function GetNewDeck(){
//     fetch("https://deckofcardsapi.com/api/deck/new/",
//     {
//         method: "get",
//         headers: {"Accept": "application/json"}
//     })
//     .then(response => response.json())
//     .then(deck => {
//         if(deck.success === true)
//         {
//             let newDeck: Deck = {
//                 DeckId: deck.deck_id,
//                 shuffled: deck.shuffled,
//                 remaining: deck.remaining
//             }
//             const d = document.createElement("p");
//             d.innerHTML = `${newDeck.DeckId} ${newDeck.remaining}`;
//             document.body.append(d); 
//         }
//     })
// }

function DrawCard(){
    
    fetch("https://deckofcardsapi.com/api/deck/new/draw/?count=1",
    {
        method: "get",
        headers: {"Accept": "application/json"}
    })
    .then(response => response.json())
    .then(deck => {
        debugger;
        const c = document.createElement("img");
        c.src = deck.cards[0].image;
        document.body.appendChild(c); 
    })
       
}

