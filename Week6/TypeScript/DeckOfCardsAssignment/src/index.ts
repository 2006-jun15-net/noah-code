import Deck from "./deck";
import Card from "./card";

GetNewDeck(){
    fetch("https://deckofcardsapi.com/api/deck/new/",
    {
        method: "get",
        headers: {"Accept": "application/json"}
    })
    .then(response => response.json())
    .then(deck => {
        if(deck.success === true)
        {
            let newDeck: Deck = {
                DeckId: deck.deck_id,
                shuffled: deck.shuffled,
                remaining: deck.remaining
            }
            const d = document.createElement("p");
            d.innerHTML = `${newDeck.DeckId} ${newDeck.remaining}`;
            document.body.append(d); 
        }
    })
}

DrawCard(){
    fetch("https://deckofcardsapi.com/api/deck/<<deck_id>>/draw/?count=1",
    {
        method: "get",
        headers: {"Accept": "application/json"}
    })
    .then(response => response.json())
    .then(card =>
        {
            if(card.success === true)
            {
                const newCard: Card = {
                    image: card.image,
                    value: card.value,
                    suit: card.suit, 
                    code: card.code
                }
            }
        })
}

