export default function PopularDest() {
  const listContent = [
    {
      id: 0,
      imgsrc: "/assets/populardestimages/Lake Ohrid.png",
      alt: "Lake Ohrid",
      title: "Lake Ohrid",
    },
    {
      id: 1,
      imgsrc: "/assets/populardestimages/Kratovo.png",
      alt: "Kratovo",
      title: "Kratovo",
    },
    {
      id: 2,
      imgsrc: "/assets/populardestimages/Tetovo.png",
      alt: "Tetovo",
      title: "Tetovo",
    },
    {
      id: 3,
      imgsrc: "/assets/populardestimages/Lake Matka.png",
      alt: "Lake Matka",
      title: "Lake Matka",
    },
  ];
  return (
    <section className="populardest my-10">
      <div className="wrapper">
        <div className="populardest_content flex flex-col gap-10">
          <div className="populardest_header flex flex-col gap-3">
            <h3 className="text-gray-800 lg:text-4xl md:text-3xl xs:text-2xl text-xl font-semibold">
              Popular travel destinations in North Macedonia
            </h3>
          </div>

          <div className="populardest_list grid sm:grid-cols-2 md:gap-6 grid-cols-1 gap-4">
            {listContent.map(
              ({ id, imgsrc, alt, title}) => (
                <div
                  className="populardest_list_item  rounded-xl overflow-clip h-max w-auto drop-shadow-md"
                  key={id}
                >
                  <img
                    loading="lazy"
                    src={imgsrc}
                    alt={alt}
                    className="populardest_element_image w-full"
                  />
                  <div className="populardest_item_text xs:px-6 xs:pb-8 xs:pt-4 px-4 pb-6 pt-2 h-fill bg-[#222222] flex flex-col gap-3">
                    <h5 className="lg:text-2xl md:text-xl xs:text-lg font-bold text-gray-50">
                      {title}
                    </h5>
                    
                  </div>
                </div> 
              )
            )}
          </div>
        </div>
      </div>
    </section>
  );
}