"use client";
import { useEffect, useRef, useState } from "react";

export default function HeroSection() {
  const contentRef = useRef<HTMLDivElement>(null);
  const videoRef = useRef<HTMLVideoElement>(null);
  const [fading, setFading] = useState<boolean>(false);
  const [isModalOpen, setIsModalOpen] = useState<boolean>(false);
  const countries = [
    "Albania",
    "Canada",
    "Germany",
    "North Macedonia",
    "Romania",
    "Serbia",
    "United Kingdom",
    "United States",
  ];
  const [location, setLocation] = useState("");
  const [adults, setAdults] = useState(1);
  const [checkIn, setCheckIn] = useState("");
  const [checkOut, setCheckOut] = useState("");

  useEffect(() => {
    const video = videoRef.current;

    if (!video) return;

    const handleTimeUpdate = () => {
      if (video.duration - video.currentTime < 0.5 && !fading) {
        setFading(true);
        video.style.transition = "opacity 0.4s ease-out";
        video.style.opacity = "0";
      }

      if (video.currentTime < 0.2 && fading) {
        video.style.opacity = "1";
        setFading(false);
      }
    };

    video.addEventListener("timeupdate", handleTimeUpdate);

    return () => {
      video.removeEventListener("timeupdate", handleTimeUpdate);
    };
  }, [fading]);


  return (
    <section className="hero relative max-h-dvh">
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
      <div className="min-h-dvh flex items-center justify-center bg-black/20 relative w-full h-dvh z-10">
        <div
          ref={contentRef}
          className="hero__content wrapper relative text-center flex flex-col items-center justify-center lg:gap-32 sm:gap-16 gap-8 py-2"
        >
          <h2 className={`lg:text-7xl sm:text-6xl text-5xl font-bold flex flex-col transition-all duration-1000 ease-in-out ${isModalOpen ? "opacity-70 xs:-translate-y-4 -translate-y-36":"opacity-100 translate-y-0"}`}>
            <span>Find Your</span>
            <span>Perfect Space</span>
          </h2>
        
          <div className='herosection_search_button flex flex-col justify-center items-center lg:h-[100px] xs:h-[200px] h-[100px] max-w-[600px] w-full lg:max-w-full'>
            <div className={`herosection_searchbar z-10 flex lg:flex-row flex-col content-center bg-gray-50 py-4 lg:gap-0 xs:gap-10 gap-8 px-4 rounded-lg w-full lg:w-max lg:max-w-full max-w-[800px] transition-all ease-in-out duration-1000 ${isModalOpen ? 'opacity-100 pointer-event-auto translate-w-0' :'opacity-0 pointer-events-none translate-w-full'}`}>
              <div className='herosection_input_row flex xs:flex-row flex-col w-full lg:w-max lg:gap-0 xs:gap-10 gap-8'>
              {/* Location Input*/}
              <div className='flex flex-col gap-4 xl:min-w-[240px] lg:min-w-[180px] lg:text-lg md:text-base w-full'>
                <label className='text-gray-800 font-semibold'>Location</label>
                <select
                  id="location"
                  value={location}
                  onChange={(e) => setLocation(e.target.value)}
                  className="text-center text-gray-600"
                >
                  <option value="">Select country</option>
                  {countries.map((country) => (
                    <option key={country} value={country}>
                      {country}
                    </option>
                  ))}
                </select>
              </div>
              {/* Adults */}
              <div className='flex flex-col gap-4 xl:min-w-[240px] lg:min-w-[180px] lg:text-lg md:text-base w-full'>
                <label className=" text-gray-800 font-semibold">Adults</label>
                <select
                  value={adults}
                  onChange={(e) => setAdults(Number(e.target.value))}
                  className="text-center text-gray-500 text-lg"
                >
                  {Array.from({ length: 10 }, (_, i) => i + 1).map((num) => (
                    <option key={num} value={num}>
                      {num}
                    </option>
                  ))}
                </select>
              </div>
              </div>
              <div className='herosection_input_row flex lg:gap-0 md:gap-8 xs:gap-10 gap-8 xs:flex-row flex-col'>
              {/* Check-in*/}
              <div className='flex flex-col gap-4 xl:min-w-[240px] lg:min-w-[180px] content-center lg:text-lg md:text-base w-full lg:w-max'>
                <label className="text-gray-800 font-semibold self-center">Check-in</label>
                <input
                  type="date"
                  value={checkIn}
                  onChange={(e) => setCheckIn(e.target.value)} className="text-center text-gray-500 text-lg"
                />
              </div>
              {/* Check-out*/}
              <div className='flex flex-col gap-4 xl:min-w-[240px] lg:min-w-[180px] content-center lg:text-lg md:text-base w-full'>
                <label className="text-gray-800 font-semibold self-center">Check-out</label>
                <input
                  type="date"
                  value={checkOut}
                  onChange={(e) => setCheckOut(e.target.value)} className="text-center text-gray-500 text-lg"
                />
              </div>
              </div>
              <div className='xl:min-w-[240px] lg:min-w-[180px] flex justify-center items-center'>
                <button onClick={()=>setIsModalOpen((prev)=>!prev)} className='py-4 xs:px-12 sm:w-max w-full rounded-sm bg-[#D57800] font-medium cursor-pointer '>Search</button>
                </div>
              
              
            </div>
          {!isModalOpen&&(
<button onClick={()=>setIsModalOpen(true)} className='py-4 xs:px-12 sm:w-max w-full rounded-sm bg-[#D57800] font-medium cursor-pointer absolute bottom-50%'>Get started</button>
              )}
          
        </div></div>
            
        
      </div>
    </section>
  );
}