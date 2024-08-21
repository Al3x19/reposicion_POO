import React from "react";
import { Link } from "react-router-dom";
import { IoGameController } from "react-icons/io5";


export const Navbar = () => {
  return (
    <nav className="px-6 py-4 bg-gray-100 shadow-lg">
      <div className="container flex flex-col mx-auto md:flex-row md:items-center md:justify-between">
        <div className="flex items-center justify-between w-full md:w-auto">
          <Link
            to="/home"
            className="my-1 text-gray-800 hover:text-gray-600 md:mx-4 md:my-0"
          >
            Inicio
          </Link>
          <Link
            to="/home"
            className="my-1 text-gray-800 hover:text-gray-600 md:mx-4 md:my-0"
          >
            Jugar
          </Link>
          <IoGameController />

        </div>
      </div>
    </nav>
  );
};
