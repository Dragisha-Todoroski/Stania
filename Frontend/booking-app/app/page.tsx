import type { Metadata } from "next";
import Header from "../components/layout/Header";

export const metadata: Metadata = {
  title: "Booking App",
  description: "Booking App",
};

export default function Home() {
  return (
    <>
      <Header />
    </>
  );
}
