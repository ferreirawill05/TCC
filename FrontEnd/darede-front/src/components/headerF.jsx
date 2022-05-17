import React from 'react';
import { Link } from 'react-router-dom';
import { Component, useState } from 'react';

import Modal from '../components/modal'

import logo from '../assets/logo-darede.svg'
import perfil from '../assets/icon-perfil.svg'
import plus from '../assets/icon-plus.svg'
import filter from '../assets/icon-filter.svg'

import '../style/header.css'

export default function HeaderF() {

    const [isModalVisible, setIsModalVisible] = useState(false);

    return (
        <header>
            <div className='header-box'>
                <div className='box-direita-header'>
                    <img className='logo-header' src={logo} alt="logo-darede" />
                </div>
                <div className='box-esquerda-header'>
                    <button className='button-header' onClick={() => setIsModalVisible(true)}>
                        <img className='img-header button-img' src={plus} alt="icon-cadastro-infraestrutura" />
                        <span className='button-span-header'>Nova Infraestrutura</span>
                    </button>
                    {isModalVisible ?

                        <Modal>
                            <h1>Cadastrar Infraestrutura</h1>
                            <div className="modal-cadastro">
                                <form action="submit">

                                    <h2>Informações do Cliente</h2>
                                    <div className="input-group input-group1">
                                        <input type="text" placeholder="Nome do Cliente" />
                                        <input type="email" placeholder="Email" />
                                    </div>

                                    <h2>Informações do Servidor</h2>
                                    <div className="input-group input-group2">
                                        <div className="input-group-column">
                                            <input type="text" placeholder="Memória" />
                                            <input type="text" placeholder="Armazenamento" />
                                            <input type="text" placeholder="Processador" />
                                        </div>
                                        <div className="input-group-column">
                                            <input type="text" placeholder="Sistema Operacional" />
                                            <input type="text" placeholder="Tipo de Instância" />
                                            <input type="text" placeholder="CPU" />
                                        </div>
                                    </div>

                                    <h2>Informações de Rede</h2>
                                    <div className="input-group input-group2">
                                        <div className="input-group-column">
                                            <input type="text" placeholder="Ip Privado" />
                                            <input type="text" placeholder="Máscara" />
                                            <input type="text" placeholder="Gateway" />
                                        </div>
                                        <div className="input-group-column">
                                            <input type="text" placeholder="Ip Público" />
                                            <input type="text" placeholder="Máscara" />
                                            <input type="text" placeholder="Zona de Disponibilidade" />
                                        </div>
                                    </div>
                                    <button type="submit" className="btn-formL"/* onClick executar cadastro, se cadastro der certo, fechar modal; senão mostrar mensagem de erro*/ >Cadastrar</button>
                                </form>
                            </div>
                        </Modal> : null}
                    <button className='button-header'>
                        <img className='img-header button-img' src={filter} alt="icon-filtrar-por" />
                        <span className='button-span-header'>Filtrar por</span>
                    </button>
                    <img class='img-header icon-perfil' src={perfil} alt="icon-perfil" />
                </div>
            </div>
        </header>
    )
}