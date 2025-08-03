"use client";
import { useEffect, useState } from "react";
import Link from "next/link";
import { Menu, Sailboat, X } from "lucide-react";

export default function Header() {
  const [scrolled, setScrolled] = useState<boolean>(false);
  const [menuOpen, setMenuOpen] = useState<boolean>(false);

  useEffect(() => {
    const handleScroll = () => {
      setScrolled(window.scrollY > 0);
    };
    window.addEventListener("scroll", handleScroll);
    return () => window.removeEventListener("scroll", handleScroll);
  }, []);

  type NavigationItemsType = {
    name: 'home' | 'about' | 'services' | 'contact' | 'blog'
    href: '/' | '/about' | '/services' | '/contact' | '/blog'
  }

  const navigationItems: NavigationItemsType[] = [
    { name: "home", href: "/" },
    { name: "about", href: "/about" },
    { name: "services", href: "/services" },
    { name: "contact", href: "/contact" },
    { name: "blog", href: "/blog" },
  ];

  return (
    <header
      className={`fixed top-0 left-0  right-0 w-full py-4 z-50 transition-all duration-500 ease-in-out ${
        scrolled || menuOpen
          ? "bg-white/50 backdrop-blur-md text-gray-800 lg:max-w-[1200px] lg:rounded-2xl lg:top-4 lg:left-2/4 lg:-translate-x-2/4"
          : "bg-transparent"
      }`}
    >
      <div className="wrapper">
        <nav>
          <div className="flex justify-between items-center">
            {/* Logo always visible */}
            <div className="font-bold text-3xl ">
              <Link className="flex items-center gap-2" href="/">STANIA <Sailboat size={24} /></Link>
            </div>

            {/* Desktop Menu */}
            <ul className="hidden lg:flex items-center gap-4">
              {navigationItems.map(({ name, href }) => (
                <li key={name}>
                  <Link className="text-xl font-bold uppercase underline-fancy" href={href}>
                    {name}
                  </Link>
                </li>
              ))}
            </ul>

            <div className="hidden lg:flex items-center font-bold gap-4 text-xl uppercase">
              <Link className="underline-fancy" href="/login">Log In</Link>
              <Link className="underline-fancy" href="/register">Register</Link>
            </div>

            {/* Mobile Hamburger */}
            <button
              className="lg:hidden"
              onClick={() => setMenuOpen((prev) => !prev)}
              aria-label="Toggle menu"
            >
              {menuOpen ? <X size={32} /> : <Menu size={32} />}
            </button>
          </div>

          {/* Mobile Dropdown Menu */}
          <div
            className={`lg:hidden overflow-hidden transition-all duration-300 ${
              menuOpen ? "max-h-[800px] h-full opacity-100 mt-14" : "max-h-0 opacity-0"
            }`}
          >
            <ul className="flex flex-col gap-4">
              {navigationItems.map(({ name, href }) => (
                <li key={name}>
                  <Link
                    className="block underline-fancy text-xl uppercase font-bold"
                    href={href}
                    onClick={() => setMenuOpen(false)}
                  >
                    {name}
                  </Link>
                </li>
              ))}
              <li>
                <Link
                  className="block underline-fancy text-xl uppercase font-bold"
                  href="/login"
                  onClick={() => setMenuOpen(false)}
                >
                  Log In
                </Link>
              </li>
              <li>
                <Link
                  className="block underline-fancy text-xl uppercase font-bold"
                  href="/register"
                  onClick={() => setMenuOpen(false)}
                >
                  Register
                </Link>
              </li>
            </ul>
          </div>
        </nav>
      </div>
    </header>
  );
}
