// import AlisaPropertyImg from '../../assets/Old Alisa_Property.png';
export default function TopProp() {
  const listContent = [
    {
      id: 0,
      imgsrc: "/assets/toppropimages/Old Alisa_Property.png",
      alt: "Old Alisa Property",
      title: "Old Alisa",
      location: "Skopje",
      grade: "9.1",
      reviews: "12",
    },
    {
      id: 1,
      imgsrc: "/assets/toppropimages/House Maja_Property.png",
      alt: "House Maja Property",
      title: "House Maja",
      location: "Skopje",
      grade: "9.3",
      reviews: "15",
    },
    {
      id: 2,
      imgsrc: "/assets/toppropimages/House Fenix_Property.png",
      alt: "House Fenix Property",
      title: "House Fenix",
      location: "Skopje",
      grade: "9.1",
      reviews: "24",
    },
    {
      id: 3,
      imgsrc: "/assets/toppropimages/House Lidjia_Property.png",
      alt: "House Lidjia Property",
      title: "House Lidjia",
      location: "Skopje",
      grade: "9.8",
      reviews: "19",
    },
  ];
  return (
    <section className="topprop my-6">
      <div className="wrapper">
        <div className="toprop_content flex flex-col gap-10">
          <div className="toprpop_header flex flex-col gap-3">
            <h3 className="text-gray-800 lg:text-4xl md:text-3xl xs:text-2xl text-xl font-semibold">
              Stay in our top properties
            </h3>
            <p className="lg:text-2xl md:text-xl xs:text-lg text-base font-medium text-gray-600">
              From compact apartments to villas, we offer it all.
            </p>
          </div>

          <div className="topprop_list grid lg:grid-cols-4 md:gap-6 xs:grid-cols-2 gap-4 grid-cols-1">
            {listContent.map(
              ({ id, imgsrc, alt, title, location, grade, reviews }) => (
                <div
                  className="topprop_list_item  rounded-xl overflow-clip h-full drop-shadow-md"
                  key={id}
                >
                  <img
                    loading="lazy"
                    src={imgsrc}
                    alt={alt}
                    className="projects_element_image w-full"
                  />
                  <div className="toprpop_item_text xs:px-6 xs:pb-8 xs:pt-4 px-4 pb-6 pt-2 max-h-[200px] bg-[#F6F6F6] flex flex-col gap-3">
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
                </div> 
              )
            )}
          </div>
        </div>
      </div>
    </section>
  );
}
