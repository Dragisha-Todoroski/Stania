"use client";
import Loader from "@/components/layout/Loader";
import "../styles/globals.css";
import Header from "@/components/layout/Header";
import { useState } from "react";

export default function RootLayout({
  children,
}: Readonly<{
  children: React.ReactNode;
}>) {
  const [loadingDone, setLoadingDone] = useState(false);

  return (
    <html lang="en">
      <body>
        <Loader onDone={() => setLoadingDone(true)} />
        {loadingDone && <Header />}
        {loadingDone && children}
      </body>
    </html>
  );
}
