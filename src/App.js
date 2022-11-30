import React, { useState } from 'react';
import axios from 'axios';
import "./App.css";


function App() {
  const [data, setData] = useState({})
  const [user, setuser] = useState('')


  
  const url = `http://localhost:5142/api/Music/GetAllMusic/${user}`

  


  const searchuser = (event) => {
    if (event.key === 'Enter') {
      axios.get(url).then((response) => {
        setData(response.data)
        console.log(response.data)
      })
      //setLocation('')
    }
  }
  return (
    
    <div className="app">
      <div className='king'>
      <h1>MUSIC FINDER</h1> 
      </div>

{/* MUSIC NOTES ANIMATIONS */}
      <div class="main1">
      <div class="ani1">
      &#9835; &#9833;
      </div>

      <div class="ani2">
      &#9833;
      </div>

      <div class="ani3">
      &#9839; &#9834;
      </div>
        
      <div class="ani4">
       &#9834;
      </div>
      </div>

{/* TEXT BOX */}
      <div className="search">
        <input
          value={user}
          onChange={event => setuser(event.target.value)}
          onKeyPress={searchuser}
          placeholder='Enter Location'
          type="text" />
      </div>

      <div className="container">
        <div className="top">
          <div className="location">           
            <p>{data.artist}</p>
          </div>

          <div className="temp">
            <p>{data.gender}</p>
          </div>

          <div className="temp">
            <p>{data.age}</p>
          </div>

          <div className="temp">
            <p>{data.albums}</p>
          </div>

          <div className="temp">
            <p>{data.years}</p>
          </div>

          <div className="temp">
        <p><img src={data.images} alt={data.albums} width="100px" height="100px"/></p>
          </div>

          <div className="temp">
            <p>{data.lyrics}</p>
          </div>   
        </div>                    
        </div>        
      </div>
    
      
      

      
  );
  
}
export default App;