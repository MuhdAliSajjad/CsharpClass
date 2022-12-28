import React from 'react';
import ReactDOM from 'react-dom/client';
// import './index.css';
import './MovieApp/index.css';
// import App from './Components/RandomNumber';
import Main from './MovieApp/Main'
// import App from './App';
// import App from './Components/ReactRedux';
import reportWebVitals from './reportWebVitals';
// import { Provider } from 'react-redux';
// import store from './store';

const root = ReactDOM.createRoot(document.getElementById('root'));
// root.render(
  // <Provider store={store}>
  // <React.StrictMode>
  //   <App />
  // </React.StrictMode>
  // </Provider>
  //  );
root.render(
  <React.StrictMode>
    <Main />
  </React.StrictMode>
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
