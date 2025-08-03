"use client";

import { useEffect, useRef } from "react";
import { gsap } from "gsap";
import { ScrollTrigger } from "gsap/ScrollTrigger";

gsap.registerPlugin(ScrollTrigger);

export default function Hero() {
  const videoRef = useRef<HTMLVideoElement>(null);
  const contentRef = useRef<HTMLDivElement>(null);

  useEffect(() => {
    if (videoRef.current) {
      videoRef.current.playbackRate = 0.75;
    }

    const ctx = gsap.context(() => {
      gsap.fromTo(
        contentRef.current,
        {
          y: 0,
          opacity: 1,
          scale: 1,
        },
        {
          y: -100,
          opacity: 0,
          scale: 0.95,
          scrollTrigger: {
            trigger: contentRef.current,
            start: "top center",
            end: "bottom top",
            scrub: true,
          },
        }
      );
    });

    return () => ctx.revert();
  }, []);

  return (
    <section className="hero relative max-h-dvh -z-20">
      <div className="hero-video__wrapper -z-10">
        <video
          ref={videoRef}
          className="w-full h-full fixed object-cover top-0 left-0"
          src="/videos/hero-video.mp4"
          autoPlay
          loop
          muted
        ></video>
      </div>
      <div className="min-h-dvh flex items-center justify-center bg-black/20 relative z-10 w-full h-dvh">
        <div
          ref={contentRef}
          className="hero__content relative text-center flex flex-col gap-2"
        >
          <h2 className="text-7xl font-bold libre-caslon">STANIA</h2>
        </div>
      </div>
    </section>
  );
}
