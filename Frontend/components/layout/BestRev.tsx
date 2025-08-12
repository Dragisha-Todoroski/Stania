export default function BestRev() {
  const listContent = [
    {
      id: 0,
      imgsrc: "/assets/bestrevimages/Danica House.png",
      alt: "Danica House Property",
      title: "Danica House",
      location: "Skopje",
      grade: "9.1",
      reviews: "12",
      price:'1000',
    },
    {
      id: 1,
      imgsrc: "/assets/bestrevimages/Guesthouse Krapce.png",
      alt: "Guesthouse Krapce Property",
      title: "Guesthouse Krapce",
      location: "Skopje",
      grade: "9.3",
      reviews: "15",
      price:'1000',
    },
    {
      id: 2,
      imgsrc: "/assets/bestrevimages/House Fennel.png",
      alt: "House Fennel Property",
      title: "House Fennel",
      location: "Skopje",
      grade: "9.1",
      reviews: "24",
      price:'1000',
    },
    {
      id: 3,
      imgsrc: "/assets/bestrevimages/Granit Apartments.png",
      alt: "Granit Apartments Property",
      title: "Granit Apartments",
      location: "Skopje",
      grade: "9.8",
      reviews: "19",
      price:'1000',
    },
  ];
  return (
    <section className="bestrev my-10">
      <div className="wrapper">
        <div className="bestrev_content flex flex-col gap-10">
          <div className="bestrev_header flex flex-col gap-3">
            <h3 className="text-gray-800 lg:text-4xl md:text-3xl xs:text-2xl text-xl font-semibold">
              Best reviewed
            </h3>
          </div>

          <div className="bestrev_list grid lg:grid-cols-4 md:gap-6 xs:grid-cols-2 gap-4 grid-cols-1">
            {listContent.map(
              ({ id, imgsrc, alt, title, location, grade, reviews, price }) => (
                <div
                  className="bestrev_list_item  rounded-xl overflow-clip h-full drop-shadow-md"
                  key={id}
                >
                  <img
                    loading="lazy"
                    src={imgsrc}
                    alt={alt}
                    className="bestrev_element_image w-full"
                  />
                  <div className="bestrev_item_text flex flex-col bg-[#F6F6F6] xs:px-6 xs:pb-8 xs:pt-4 px-4 pb-6 pt-2 lg:h-[240px] xs:h-[190px] h-max justify-between">
                    <div className='bestrev_item_upper_text flex flex-col h-full gap-3 '>
                    <h5 className="lg:text-2xl md:text-xl xs:text-lg font-bold text-gray-800">
                      {title}
                    </h5>
                    <p
                      className="lg:text-lg md:text-base text-sm font-semibold
                     text-gray-600"
                    >
                      {location}
                    </p>
                    <div className="lg:text-base md:text-sm text-xs flex  gap-3 items-center">
                      <span className="bg-[#3F7D20] text-gray-50 px-2 py-1 rounded">
                        {grade}
                      </span>
                      <span className="text-gray-500">{reviews} reviews</span>
                      
                    </div>
                    </div>
                    <div className="text-gray-600 text-right lg:text-base md:text-sm text-xs"><span>Starting from </span> 
                      <b> {price} MKD</b> </div>
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