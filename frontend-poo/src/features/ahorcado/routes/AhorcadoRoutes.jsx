import { Navigate, Route, Routes } from 'react-router-dom';
//paginas
import {HomePage} from "../pages"
// componentes 
import {Navbar } from "../components"
import React from 'react'

export const AhorcadoRoutes = () => {
  return (
    <div className="overflow-x-hidden bg-white w-screen h-screen  bg-no-repeat bg-cover">
    <Navbar/>
    <div className="px-6 py-8">
      <div className="container flex justify-between mx-auto">
        <Routes>
          <Route path='/home' element={<HomePage />} />
        </Routes>
      </div>
    </div>
    {/* <Footer /> */}
  </div>
  )
}