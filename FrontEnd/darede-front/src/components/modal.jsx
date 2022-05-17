import React, { useState } from 'react';

import '../style/modal.css'

import closeIcon from '../assets/icon-close.svg';

const Modal = ({ children }) => {

    return (
        <div className='modal'>
            <div className='modal-container'>
                <button className='close' id="close-position">
                    <img src={closeIcon} alt="" className="button-img" />
                </button>
                <div className='modal-content'>{children}</div>
            </div>
        </div>
    )
}

export default Modal;