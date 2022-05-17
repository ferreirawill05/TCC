import React from 'react';
import { Link } from 'react-router-dom';

import logo from '../assets/logo-darede.svg'
import perfil from '../assets/icon-perfil.svg'
import plus from '../assets/icon-plus.svg'
import filter from '../assets/icon-filter.svg'

import '../style/header.css'
import { getByDisplayValue } from '@testing-library/react';

export default function HeaderC() {
    return (
        <header>
            <div className='header-box'>
                <div className='box-direita-header'>
                    <img className='logo-header' src={logo} alt="logo-darede" />
                </div>
                <div className='box-esquerda-header'>
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