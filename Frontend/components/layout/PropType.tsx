export default function PropType() {
  const listContent = [
    {
      id: 0,
      imgsrc: "/assets/proptypeimages/House_Image.png",
      alt: "House",
      title: "House",
    },
    {
      id: 1,
      imgsrc: "/assets/proptypeimages/Hotel_Image.png",
      alt: "Hotel",
      title: "Hotel",
    },
    {
      id: 2,
      imgsrc: "/assets/proptypeimages/Apartment_Image.png",
      alt: "Apartment",
      title: "Apartment",
    },
    {
      id: 3,
      imgsrc: "/assets/proptypeimages/Guesthouse_Image.png",
      alt: "Guesthouse",
      title: "Guesthouse",
    },
  ];
  return (
    <section className="proptype my-10">
      <div className="wrapper">
        <div className="proptype_content flex flex-col gap-10">
          <div className="proptype_header flex flex-col gap-3">
            <h3 className="text-gray-800 lg:text-4xl md:text-3xl xs:text-2xl text-xl font-semibold">
              Search by property type
            </h3>
          </div>

          <div className="proptype_list grid lg:grid-cols-4 md:gap-6 xs:grid-cols-2 gap-4 grid-cols-1">
            {listContent.map(
              ({ id, imgsrc, alt, title}) => (
                <div
                  className="proptype_list_item  rounded-xl overflow-clip h-max w-auto drop-shadow-md"
                  key={id}
                >
                  <img
                    loading="lazy"
                    src={imgsrc}
                    alt={alt}
                    className="proptype_element_image w-full"
                  />
                  <div className="proptype_item_text xs:px-6 xs:pb-8 xs:pt-4 px-4 pb-6 pt-2 h-fill bg-[#222222] flex flex-col gap-3">
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