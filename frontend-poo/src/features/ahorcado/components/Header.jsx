import React from 'react'
import { IoGameController } from "react-icons/io5";
import { Navbar } from './Navbar';

export const Header = () => {
  return (
    <div className="w-full h-20 px-4 py-4 border-b-2 border-gray-400">
        <header className="flex items-center justify-between mx-auto ">
        <div className="text-gray-500 font-bold text-left text-2xl mx-2">
          <p className="w-full">Ahorcado</p>
          <IoGameController />
        </div>
        <div className="container flex flex-col items-center ml-auto ">
          <Navbar />
        </div>
        </header>
    </div>
  )
}

