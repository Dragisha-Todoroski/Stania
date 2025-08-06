"use client";

import { useEffect, useState } from "react";
import { motion, AnimatePresence } from "framer-motion";

export default function Loader({ onDone }: { onDone?: () => void }) {
  const [done, setDone] = useState(false);

  useEffect(() => {
    const timeout = setTimeout(() => {
      setDone(true);
      if (onDone) onDone();
    }, 3000);
    return () => clearTimeout(timeout);
  }, [onDone]);

  return (
    <AnimatePresence>
      {!done && (
        <motion.div
          initial={{ opacity: 0 }}
          animate={{ opacity: 1 }}
          exit={{ opacity: 0 }}
          transition={{ duration: 0.8 }}
          className="flex items-center justify-center min-h-screen bg-white text-black fixed inset-0 z-50"
        >
          <motion.svg
            xmlns="http://www.w3.org/2000/svg"
            viewBox="0 0 256 256"
            className="w-32 h-32"
            fill="none"
            stroke="currentColor"
            strokeWidth="16"
            strokeLinecap="round"
            strokeLinejoin="round"
          >
            <motion.path
              d="M16,176H240l-29.6,37a8,8,0,0,1-6.24,3H51.84a8,8,0,0,1-6.24-3Z"
              initial={{ pathLength: 0 }}
              animate={{ pathLength: 1 }}
              transition={{ duration: 1.2, ease: "easeInOut" }}
            />
            <motion.polyline
              points="136 136 216 136 136 48"
              initial={{ pathLength: 0 }}
              animate={{ pathLength: 1 }}
              transition={{ duration: 1.2, ease: "easeInOut", delay: 0.3 }}
            />
            <motion.polyline
              points="136 176 136 8 32 136 136 136"
              initial={{ pathLength: 0 }}
              animate={{ pathLength: 1 }}
              transition={{ duration: 1.2, ease: "easeInOut", delay: 0.6 }}
            />
          </motion.svg>
        </motion.div>
      )}
    </AnimatePresence>
  );
}
