import type { Metadata } from "next";
import Hero from "@/components/layout/Hero";
import Listings from "@/components/layout/Listings";

export const metadata: Metadata = {
  title: "Stania",
  description: "Stania - Booking App Designed and Developed by: Dragisha Todoroski, Daniel Cikora and Teodora Dumitru.",
};

export default function Home() {
  return (
    <>
      <Hero />
      <Listings />
    </>
  );
}
