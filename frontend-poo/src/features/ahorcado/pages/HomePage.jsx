import React from 'react'

export const HomePage = () => {
  return (
    <div className="bg-gray-500 w-full flex flex-col items-center content-center">
      <div className="w-full h-auto bg-gray-100 px-6 py-4 flex justify-center border-b-2 border-black">
        <div className="text-center mb-10">
          <h3 className="text-3xl sm:text-4xl leading-normal font-extrabold tracking-tight text-gray-900">
            Ahorcado
          </h3>
        </div>
      </div>
      <div className="w-full max-w-6xl bg-white rounded-lg shadow-md hover:shadow-lg transition-shadow duration-300 ease-in-out transform hover:scale-105 p-6">
        <div className="border-t-black"><h4 className="bg-zinc-500">Nombre</h4></div>
      </div>
    </div>

  )
}

