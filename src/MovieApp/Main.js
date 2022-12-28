import React,{useEffect, useState} from "react";
import '../MovieApp/index.css'
import Card from "./Card";
//import axios from "axios";


function Main(){
    const api_key = "api_key=2b293925aad4348463ffa2292e715028";
    const base_url = "https://api.themoviedb.org/3";
    const api_url = base_url +"/discover/movie?sort_by=popularity.desc&" +api_key;

    const [movieData, setData] = useState([]);
    const [url_set, setUrl] = useState(api_url);
    const [genres, setGenres]=useState(null);
    
    useEffect(() =>{
        fetch(url_set).then(res => res.json()).then(data=>{
             console.log(data.results)
            // here is the func to get the data results from the tmdb in the form of json
            setData(data.results);
        })
    },[url_set])




    return(

        <>
        <div className="header">
            <img src="data:image/jpeg;base64,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" className="logo" alt="Image"/>
            <form id="form">       
                    <input type="text" placeholder="Enter a movie Name" id="search" className="search"/>
                    <button className="LogOut">Log Out</button>                
            </form>
        </div>
        <div id="tags">
            <div className="tags">Action</div>
            <div className="tags">Adveture</div>
            <div className="tags">Drama</div>
            <div className="tags">Comedy</div>
        </div>


        <div className="container" id="main">
        {
            (movieData.length==0)?<p className="NotFound">Not Found</p>: movieData.map((res,pos)=>{
                return(
                    <Card info={res} key={pos} />
                )
            })
        }
        </div>
        
        
        
        
        </>
 
    )
}


export default Main;