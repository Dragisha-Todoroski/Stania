'use client';
import { useEffect, useRef, useState } from 'react';

export default function HeroDesign() {
 const contentRef = useRef<HTMLDivElement>(null);
 const videoRef = useRef<HTMLVideoElement>(null);
 const [fading, setFading] = useState<boolean>(false);
 const [isModalOpen, setIsModalOpen] = useState<boolean>(false);
 const countries = [
  'Albania',
  'Canada',
  'Germany',
  'North Macedonia',
  'Romania',
  'Serbia',
  'United Kingdom',
  'United States',
 ];
 const [location, setLocation] = useState('');
 const [adults, setAdults] = useState(1);
 const [checkIn, setCheckIn] = useState('');
 const [checkOut, setCheckOut] = useState('');

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
  <section className='hero relative max-h-dvh'>
   <div className='hero-video__wrapper max-h-screen h-ful'>
    <video
     ref={videoRef}
     className='w-full max-h-screen h-full absolute object-cover top-0 left-0 transition-opacity duration-500'
     src='/videos/hero-video.webm'
     autoPlay
     loop
     muted
    ></video>
   </div>
   <div className='min-h-dvh flex items-center justify-center bg-black/40 relative w-full h-dvh z-10 px-4'>
    <div
     ref={contentRef}
     className='hero__content wrapper relative text-center flex flex-col items-center lg:gap-32 sm:gap-16 gap-8 py-2'
    >
     <h2
      className={`lg:text-7xl sm:text-6xl text-5xl font-bold flex flex-col transition-all duration-1000 ease-in-out ${
       isModalOpen ? 'opacity-70 xs:-translate-y-4 -translate-y-40' : 'opacity-100 translate-y-0'
      }`}
     >
      <span>Find Your</span>
      <span>Perfect Space</span>
     </h2>
     {!isModalOpen && (
      <button
       onClick={() => setIsModalOpen(true)}
       className='bg-orange-600 text-white text-lg rounded-md px-12 py-4 sm:w-max w-full cursor-pointer'
      >
       Start searching
      </button>
     )}
     {isModalOpen && (
      <div className='herosection_searchbar z-10 flex lg:flex-row flex-col content-center bg-gray-50 py-4 lg:gap-0 gap-8 px-4 rounded-lg w-full max-w-[600px] lg:max-w-full'>
       <div className='herosection_input_row flex w-full lg:gap-0 md:gap-8 gap-2'>
        {/* Location Input*/}
        <div className='flex flex-col gap-4 xl:min-w-[200px] lg:min-w-[160px] lg:text-lg md:text-base w-full'>
         <label className='text-gray-800 font-semibold'>Location</label>
         <select
          id='location'
          value={location}
          onChange={(e) => setLocation(e.target.value)}
          className='text-center text-gray-600'
         >
          <option value=''>Select country</option>
          {countries.map((country) => (
           <option key={country} value={country}>
            {country}
           </option>
          ))}
         </select>
        </div>
        {/* Adults */}
        <div className='flex flex-col gap-4 xl:min-w-[200px] lg:min-w-[160px] lg:text-lg md:text-base w-full'>
         <label className=' text-gray-800 font-semibold'>Adults</label>
         <select
          value={adults}
          onChange={(e) => setAdults(Number(e.target.value))}
          className='text-center text-gray-500 text-lg'
         >
          {Array.from({ length: 10 }, (_, i) => i + 1).map((num) => (
           <option key={num} value={num}>
            {num}
           </option>
          ))}
         </select>
        </div>
       </div>
       <div className='herosection_input_row flex lg:gap-0 md:gap-8 gap-2'>
        {/* Check-in*/}
        <div className='flex flex-col gap-4 xl:min-w-[200px] lg:min-w-[160px] content-center lg:text-lg md:text-base xs:text-sm w-full'>
         <label className='text-gray-800 font-semibold self-center'>Check-in</label>
         <input
          type='date'
          value={checkIn}
          onChange={(e) => setCheckIn(e.target.value)}
          className='text-center text-gray-500 text-lg'
         />
        </div>
        {/* Check-out*/}
        <div className='flex flex-col gap-4 xl:min-w-[200px] lg:min-w-[160px] content-center lg:text-lg md:text-base w-full'>
         <label className='text-gray-800 font-semibold self-center'>Check-out</label>
         <input
          type='date'
          value={checkOut}
          onChange={(e) => setCheckOut(e.target.value)}
          className='text-center text-gray-500 text-lg'
         />
        </div>
       </div>
       <div className='xl:min-w-[200px] lg:min-w-[160px] flex justify-center items-center'>
        <button className='py-4 lg:px-12 lg:w-max w-full rounded-sm bg-orange-600 text-lg cursor-pointer '>
         Search
        </button>
       </div>
      </div>
     )}
    </div>
   </div>
   <div className='bg-amber-600'>hello</div>
  </section>
 );
}
