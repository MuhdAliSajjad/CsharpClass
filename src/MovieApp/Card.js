import React from 'react';

const Card=(movie)=>{
    // console.log(movie.info);
    const img_path = 'https://image.tmdb.org/t/p/w500';
    return(
        <>
        <div className="movie">
            <img src={img_path+movie.info.poster_path} alt="Image" />
            <div className='movie-details'>
                <div className="movie-info">
                    <h3>{movie.info.title}</h3>
                    <span className="green">{movie.info.vote_average}</span>
                </div>
                <div className="overview">
                    <h3>Overview</h3>
                    {movie.info.overview}
                </div>
            </div>
        </div>
        </>
    )
}


export default Card;