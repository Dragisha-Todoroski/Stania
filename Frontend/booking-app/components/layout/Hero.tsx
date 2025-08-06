'use client';
import { useEffect, useRef, useState } from 'react';

export default function Hero() {
 const contentRef = useRef<HTMLDivElement>(null);
 const videoRef = useRef<HTMLVideoElement>(null);
 const [fading, setFading] = useState<boolean>(false);

 useEffect(() => {
  const video = videoRef.current;

  if (!video) return;

  const handleTimeUpdate = () => {
   if (video.duration - video.currentTime < 0.5 && !fading) {
    setFading(true);
    video.style.transition = 'opacity 0.4s ease-out';
    video.style.opacity = '0';
   }

   if (video.currentTime < 0.2 && fading) {
    video.style.opacity = '1';
    setFading(false);
   }
  };

  video.addEventListener('timeupdate', handleTimeUpdate);

  return () => {
   video.removeEventListener('timeupdate', handleTimeUpdate);
  };
 }, [fading]);

 return (
  <section className='hero relative max-h-dvh -z-20'>
   <div className='hero-video__wrapper -z-10'>
    <video
     ref={videoRef}
     className='w-full h-full fixed object-cover top-0 left-0 transition-opacity duration-500'
     src='/videos/hero-video.webm'
     autoPlay
     loop
     muted
    ></video>
   </div>
   <div className='min-h-dvh flex items-center justify-center bg-black/20 relative z-10 w-full h-dvh'>
    <div ref={contentRef} className='hero__content relative text-center flex flex-col gap-2'>
     <h2 className='text-7xl font-bold'>STANIA</h2>
    </div>
   </div>
  </section>
 );
}
