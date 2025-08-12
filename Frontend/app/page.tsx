import type { Metadata } from 'next';
import HeroSection from '@/components/layout/HeaderSection';
import TopProp from '@/components/layout/TopProp';
import PropType from '@/components/layout/PropType';
import BestRev from '@/components/layout/BestRev';

export const metadata: Metadata = {
 title: 'Stania',
 description: 'Stania - Booking App Designed and Developed by: Dragisha Todoroski, Daniel Cikora and Teodora Dumitru.',
 icons: '/icons/navigation/sailboat.svg',
};


export default function Home() {
 return (
  <>
   <HeroSection />
   <TopProp />
   <PropType/>
   <BestRev/>
  </>
 );
}
