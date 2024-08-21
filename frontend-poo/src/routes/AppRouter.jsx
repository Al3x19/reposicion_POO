import { Route, Routes } from "react-router-dom";
import { AhorcadoRoutes } from "../features/ahorcado/routes/AhorcadoRoutes";

export const AppRouter = () => {
  return (
    <Routes>
      <Route path="*" element={<AhorcadoRoutes/>} />
    </Routes>
  );
};
