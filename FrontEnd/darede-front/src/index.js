import React from 'react';
import ReactDOM from 'react-dom';
import { Route, BrowserRouter as Router, Redirect ,Switch } from 'react-router-dom';
import { parseJWT, usuarioAutenticacao } from './services/auth';
import './index.css';
import reportWebVitals from './reportWebVitals';

import './style/modal.css'

import telaCadastro from './screens/telaCadastro'
import telaLogin from './screens/telaLogin'
import homeF from './screens/homeF'
import homeC from './screens/homeC'
import notFound from './screens/notFound'

const PermissaoF = ({ component: Component }) => (
  <Route
    render={(props) =>
      usuarioAutenticacao() && parseJWT().role === '1' ? (
        <Component {...props} />
      ) : (
        <Redirect to="homeC" />
      )
    }
  />
);

const PermissaoC = ({ component: Component }) => (
  <Route
    render={(props) =>
      usuarioAutenticacao() && parseJWT().role === '2' ? (
        <Component {...props} />
      ) : (
        <Redirect to="homeF" />
      )
    }
  />
);

const routing = (
  <Router>
    <div>
      <Switch>
        <Route exact path="/" component={telaLogin} />
        <Route path="/cadastro" component={telaCadastro} /> {/* Cadastro */}
        <Route path="/homeF" component={homeF} /> {/* Home Funcionário */}
        <Route path="/homeC" component={homeC} /> {/* Home Cliente */}
        <Route path="/notFound" component={notFound} /> {/* Not Found */}
        <Redirect to="/notFound"/> {/* Redireciona para Not Found caso não encontre nenhuma rota */}
      </Switch>
    </div>
  </Router>

);

ReactDOM.render(
  routing,
  document.getElementById('root')
);


// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals

reportWebVitals();
