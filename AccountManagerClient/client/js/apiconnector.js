const app = document.getElementById('root')

const container = document.createElement('div')
container.setAttribute('class', 'container')

app.appendChild(container)

var request = new XMLHttpRequest()

request.open('GET', 'https://localhost:5001/api/test/games', true)

request.onload = function() 
{
    var data = JSON.parse(this.response)

    if(request.status >= 200 && request.status < 400)
    {
        data.forEach(game => 
        {
            const card = document.createElement('div')
            card.setAttribute('class', 'card')

            const h1 = document.createElement('h1')
            h1.textContent = game.Name

            const p = document.createElement('p')
            game.ReleaseDate = game.ReleaseDate.substring(0, 10)
            p.textContent = `Release Date: ${game.ReleaseDate}`

            container.appendChild(card)

            card.appendChild(h1)
            card.appendChild(p)
        })
    }
    else
    {
        console.log('Error')
    }
    
}

request.send()